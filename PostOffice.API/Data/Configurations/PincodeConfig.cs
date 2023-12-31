﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostOffice.API.Data.Models;
using System.Diagnostics;

namespace PostOffice.API.Data.Configurations
{
    public class PincodeConfig : IEntityTypeConfiguration<Pincode>
    {
        public void Configure(EntityTypeBuilder<Pincode> builder)
        {
            builder.ToTable("Pincodes");
            builder.HasKey(p => p.pincode);
            builder.Property(p => p.city_name).IsRequired();     
            builder.HasOne(p => p.Area).WithMany(a => a.Pincodes).HasForeignKey(a =>a.area_id).IsRequired();
            builder.HasMany(p => p.OfficeBranches).WithOne(a => a.Pincode)
                .HasForeignKey(a => a.pincode).IsRequired();           
           

        }
    }
}
