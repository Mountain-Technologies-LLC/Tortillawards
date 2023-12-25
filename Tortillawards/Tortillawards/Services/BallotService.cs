using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using Tortillawards.Data;

namespace Tortillawards.Services;

internal class BallotService(ApplicationDbContext context, IIdentity identity)
{
    private readonly ApplicationDbContext _context = context;
    private readonly IIdentity _identity = identity;

    internal async Task<Ballot?> GetBallotByIdAsync(int id)
    {
        return await _context.Ballots
            .Include(x => x.CreatedBy)
            .Include(x => x.Awards.Where(a => a.Nominations.Count > 0))
                .ThenInclude(x => x.Nominations)
                    .ThenInclude(x => x.Votes.Where(x => x.CreatedBy.Email == _identity.Name))
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.Id == id);
    }
}
