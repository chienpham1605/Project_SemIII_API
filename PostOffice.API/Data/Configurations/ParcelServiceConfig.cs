using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Data.Configurations
{
    public class ParcelServiceConfig:  IEntityTypeConfiguration<ParcelService>
    {
        public void Configure(EntityTypeBuilder<ParcelService> builder)
        {
            builder.ToTable("ParcelServices");
            builder.HasKey(p => p.id);
            builder.Property(p => p.name).IsRequired();
            builder.Property(p => p.description).IsRequired();
            builder.Property(p => p.delivery_time).IsRequired();
            builder.Property(p => p.status).IsRequired();

            builder.HasOne(p => p.Price).WithMany(a => a.service_id).HasForeignKey(a => a.area_id).IsRequired();

            builder.HasMany(p => p.OfficeBranches).WithOne(a => a.Pincode).HasForeignKey(a => a.pincode).IsRequired();
        }
    }
}
