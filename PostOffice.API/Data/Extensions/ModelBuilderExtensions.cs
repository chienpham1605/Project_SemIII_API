﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
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

            modelBuilder.Entity<MoneyScope>().HasData(new MoneyScope
            {
                id = 1,
                min_value = 1,
                max_value = 1000000,
                description = "Under one million",

            },
                new MoneyScope
                {
                    id = 2,
                    min_value = 1000001,
                    max_value = 5000000,
                    description = "1 - 5 million",
                },
                new MoneyScope
                {
                    id = 3,
                    min_value = 50000001,
                    max_value = 20000000,
                    description = "5 -20 million",
                },
                new MoneyScope
                {
                    id = 4,
                    min_value = 200000001,
                    max_value = 500000000,
                    description = "20 -50 million",
                },
                new MoneyScope
                {
                    id = 5,
                    min_value = 500000001,
                    max_value = 1000000000,
                    description = "Over 50 million",
                });

                modelBuilder.Entity<MoneyServicePrice>().HasData(
                new MoneyServicePrice
                {
                    id = 1,
                    zone_type_id = 6,
                    money_scope_id = 6,
                    fee = 200000,
                }
            );
        }
    }
}

