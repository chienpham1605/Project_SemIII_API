using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace PostOffice.API.Data.Configurations
{
    public class ZoneTypeConfig : IEntityTypeConfiguration<ZoneType>
    {
        public void Configure(EntityTypeBuilder<ZoneType> builder)
        {
            builder.ToTable("ZoneTypes");
            builder.HasKey(x => x.id);
            builder.Property(x => x.zone_description).IsRequired();
        }
    }
}
