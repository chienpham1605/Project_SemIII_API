using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Data.Configurations
{
    public class ParcelServicePriceConfig : IEntityTypeConfiguration<ParcelServicePrice>
    {
        
            
               
public void Configure(EntityTypeBuilder<ParcelServicePrice> builder)
        {
            builder.ToTable("ParcelServicePrice");
            builder.HasKey(e => e.parcel_price_id);
            builder.HasMany(e => e.ZoneTypes).WithOne(z => z.ParcelServicePrice).HasForeignKey(z => z.id);
            builder.HasMany(e => e.ParcelTypes).WithOne(p => p.ParcelServicePrice).HasForeignKey(p => p.id);
            builder.HasMany(e => e.WeightScopes).WithOne(z => z.ParcelServicePrice).HasForeignKey(w => w.id);
            builder.HasMany(e => e.ParcelServices).WithOne(z => z.ParcelServicePrice).HasForeignKey(w => w.service_id);
            builder.Property(x => x.service_price).IsRequired();
        }
    }
}

