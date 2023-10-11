using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
           
            // any guid
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "onlinepostofficegroup4@gmail.com",
                NormalizedEmail = "onlinepostofficegroup4@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "aptech.123"),
                SecurityStamp = string.Empty,
                FirstName = "Pham",
                LastName = "Chien",
                Create_date = new DateTime()
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

          
        }
    }
}

