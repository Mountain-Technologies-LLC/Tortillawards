using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using Tortillawards.Data;

namespace Tortillawards.Services;

internal class VoteService(
    ApplicationDbContext context, IIdentity identity, UserManager<ApplicationUser> userManager)
{
    private readonly ApplicationDbContext _context = context;
    private readonly IIdentity _identity = identity;
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    internal async Task VoteByNominationId(int awardId, int nominationId)
    {
        try
        {
            var oldVote = await _context.Awards
                .Where(x => x.Id == awardId)
                .Include(x => x.Nominations)
                .SelectMany(x => x.Nominations)
                .Include(x => x.Votes)
                .SelectMany(x => x.Votes)
                .SingleOrDefaultAsync(x => x.CreatedBy.Email == _identity.Name);

            if (oldVote != null)
            {
                _context.Votes.Remove(oldVote);
            }
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("May be that the source contains more than one element.");
            throw;
        }

        var user = await _userManager.FindByEmailAsync(_identity.Name!);

        var newVote = new Vote
        {
            CreatedBy = user!
        };

        var nomination = await _context.Nominations
            .SingleAsync(x => x.Id == nominationId);

        nomination.Votes.Add(newVote);
        await _context.SaveChangesAsync();
    }
}
