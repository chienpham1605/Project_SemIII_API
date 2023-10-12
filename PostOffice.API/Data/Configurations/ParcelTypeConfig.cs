﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace PostOffice.API.Data.Configurations
{
    public class ParcelTypeConfig : IEntityTypeConfiguration<ParcelType>
    {
        public void Configure(EntityTypeBuilder<ParcelType> builder)
        {
            builder.ToTable("ParcelType");

            builder.HasKey(e => e.id);
            builder.Property(e => e.over_dimension_rate).IsRequired();
            builder.Property(e => e.max_height).IsRequired();
            builder.Property(e => e.max_length).IsRequired();
            builder.Property(e => e.max_weight).IsRequired();
            builder.Property(e => e.max_weight).IsRequired();
            builder.Property(e => e.name)
                .HasMaxLength(10)
                .IsRequired();
            builder.Property(e => e.description)
              .HasMaxLength(500)
              .IsRequired();
            builder.HasMany(p => p.ParcelOrders)
                .WithOne(p => p.ParcelType).HasForeignKey(p => p.parcel_type_id).OnDelete(DeleteBehavior.NoAction); ;
            
        }
    }
}
