using Microsoft.AspNetCore.Identity;

namespace Models
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
