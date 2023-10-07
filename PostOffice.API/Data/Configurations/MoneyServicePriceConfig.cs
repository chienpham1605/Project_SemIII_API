using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace PostOffice.API.Data.Configurations
{
    public class MoneyServicePriceConfig : IEntityConfiguration<MoneyServicePriceConfig>
    {
        public void Configure(EntityTypeBuilder<MoneyServicePrice> builder)
        {
            builder.ToTable("MoneyServicePrice");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();


            builder.Property(x => x.Money_scope_id).IsRequired();

            builder.Property(x => x.Fee).IsRequired();

            // Xác định mối quan hệ với MoneyScope (một MoneyService thuộc về một MoneyScope)
            builder.HasOne(x => x.MoneyScopes)
                   .WithMany()
                   .HasForeignKey(x => x.Money_scope_id);


        }
    }
}
