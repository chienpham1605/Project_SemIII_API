using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostOffice.API.Data.Models;

namespace PostOffice.API.Data.Configurations
{
    public class TrackHistoryConfig : IEntityTypeConfiguration<TrackHistory>
    {
        public void Configure(EntityTypeBuilder<TrackHistory> builder)
        { 
            builder.ToTable("TrackHistory");
            builder.HasKey(e => e.track_id);
            builder.Property(e => e.new_location)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(e => e.new_status)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(e => e.update_time)
                .HasMaxLength(50)
                .IsRequired();
            builder.Property(e => e.OrderId).HasColumnName("order_id");
            builder.Property(e => e.update_time)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("update_time");
            builder.HasOne(d => d.Employees).WithMany(p => p.History)
                .HasForeignKey(d => d.employee_id);

            builder.HasMany(d => d.).WithOne(p => p.ParcelOrder)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_track_history_order_id");
        }
    }
}
