using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Data.Configurations
{
    public class MoneyServicePriceConfig : IEntityTypeConfiguration<MoneyServicePrice>
    {
        public void Configure(EntityTypeBuilder<MoneyServicePrice> builder)
        {
            builder.ToTable("MoneyServicePrice");

            builder.HasKey(x => x.id);             

            builder.Property(x => x.fee).IsRequired();

            // Xác định mối quan hệ với MoneyScope (một MoneyService thuộc về một MoneyScope)
            builder.HasMany(x => x.MoneyScopes)
                   .WithOne(m =>m.MoneyServicePrice)
                   .HasForeignKey(m =>m.id);

            builder.HasMany(e => e.ZoneTypes)
                   .WithOne(m => m.MoneyServicePrice)
                   .HasForeignKey(w => w.id);
        }
    }
}
