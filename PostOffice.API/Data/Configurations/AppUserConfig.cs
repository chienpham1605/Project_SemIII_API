﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Data.Configurations
{
     public class AppUserConfig : IEntityTypeConfiguration<AppUser>
        {
            public void Configure(EntityTypeBuilder<AppUser> builder)
            {
                builder.ToTable("AppUsers");
                builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
                builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
                builder.Property(x => x.Create_date).IsRequired();
                builder.HasMany(x => x.ParcelOrders).WithOne(u => u.AppUser).HasForeignKey(x => x.user_id);
            }
        }    
}
