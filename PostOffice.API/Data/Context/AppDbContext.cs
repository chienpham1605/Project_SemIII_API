using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Configurations;
using PostOffice.API.Data.Extensions;
using PostOffice.API.Data.Models;
using System;
using System.Reflection.Emit;

namespace PostOffice.API.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new AreaConfig());
            builder.ApplyConfiguration(new PincodeConfig());
            builder.ApplyConfiguration(new OfficeBranchConfig());


            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new AppRoleConfig());




            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            
            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
           /* builder.Seed(); */           
        }

       /* private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Name = "Employee", ConcurrencyStamp = "2", NormalizedName = "Employee" },
                new IdentityRole() { Name = "Customer", ConcurrencyStamp = "3", NormalizedName = "Customer" }
                );

        }*/
        public DbSet<Area> Areas { get; set; }
        public DbSet<Pincode> Pincodes { get; set; }
        public DbSet<Area> OfficeBranchs { get; set; }
        


    }
}
