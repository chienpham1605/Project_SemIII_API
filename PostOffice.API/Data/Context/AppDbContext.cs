﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Configurations;
using PostOffice.API.Data.Extensions;
using PostOffice.API.Data.Models;
using System;
using System.Data;
using System.Reflection.Emit;
using PostOffice.API.Data.DTOs.MoneyScope;
using PostOffice.API.Data.DTOs.ZoneType;
using PostOffice.API.Data.DTOs.MoneyServicePriceDTO;

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

            builder.ApplyConfiguration(new MoneyOrderConfig());
            builder.ApplyConfiguration(new MoneyScopeConfig());
            builder.ApplyConfiguration(new MoneyServicePriceConfig());

            builder.ApplyConfiguration(new ParcelOrderConfig());
            builder.ApplyConfiguration(new ParcelServiceConfig());
            builder.ApplyConfiguration(new ParcelServicePriceConfig());
            builder.ApplyConfiguration(new ParcelTypeConfig());
            builder.ApplyConfiguration(new WeightScopeConfig());

            builder.ApplyConfiguration(new ZoneTypeConfig());             



            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new AppRoleConfig());




            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            builder.Seed();
        }

        /* private void SeedRoles(ModelBuilder builder)
         {
             builder.Entity<IdentityRole>().HasData(
                 new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                 new IdentityRole() { Name = "Employee", ConcurrencyStamp = "2", NormalizedName = "Employee" },
                 new IdentityRole() { Name = "Customer", ConcurrencyStamp = "3", NormalizedName = "Customer" }
                 );

         }*/
        public virtual DbSet<Area> Areas { get; set; }

        public virtual DbSet<MoneyOrder> MoneyOrders { get; set; }

        public virtual DbSet<MoneyScope> MoneyScopes { get; set; }

        public virtual DbSet<MoneyServicePrice> MoneyServices { get; set; }

        public virtual DbSet<OfficeBranch> OfficeBranches { get; set; }

        public virtual DbSet<ParcelOrder> ParcelOrders { get; set; }

        public virtual DbSet<ParcelService> ParcelServices { get; set; }

        public virtual DbSet<ParcelType> ParcelTypes { get; set; }

        public virtual DbSet<Pincode> Pincodes { get; set; }

        

        public virtual DbSet<ParcelServicePrice> ServicePrices { get; set; }

        public virtual DbSet<TrackHistory> TrackHistories { get; set; }

        public virtual DbSet<AppUser> AppUsers { get; set; }

        public virtual DbSet<WeightScope> WeightScopes { get; set; }

        public virtual DbSet<ZoneType> ZoneTypes { get; set; }

        //public DbSet<PostOffice.API.Data.DTOs.MoneyScope.MoneyScopeDTO>? MoneyScopeCreateDTO { get; set; }

        //public DbSet<PostOffice.API.Data.DTOs.ZoneType.ZoneTypeDTO>? ZoneTypeDTO { get; set; }
    
        //public DbSet<PostOffice.API.Data.DTOs.MoneyServicePriceDTO.MoneyServicePriceDTO>? MoneyServicePriceDTO { get; set; }



    }
}
