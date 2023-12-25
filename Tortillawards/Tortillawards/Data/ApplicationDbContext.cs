using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tortillawards.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Ballot> Ballots { get; set; } = default!;
    public DbSet<Award> Awards { get; set; } = default!;
    public DbSet<Nomination> Nominations { get; set; } = default!;
    public DbSet<Vote> Votes { get; set; } = default!;


}
