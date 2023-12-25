using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Tortillawards.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public required string Name { get; set; }

        public override string ToString() => Name;
    }
}
