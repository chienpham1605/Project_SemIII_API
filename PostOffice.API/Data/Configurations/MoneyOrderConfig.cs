namespace PostOffice.API.Data.Configurations
{
    public class MoneyOrderConfig : IEntityTypeConfiguration<MoneyOrder>
    {
        public void Configure(EntityTypeBuilder<MoneyOrder> builder)
        {
            builder.ToTable("MoneyOrder");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Sender_name).IsRequired().IsUnicode(true).HasMaxLength(50);
            builder.Property(x => x.Sender_name).IsRequired().IsUnicode(true).HasMaxLength(50);
            builder.Property(x => x.Sender_pincode).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Sender_phone).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Sender_address).IsRequired().IsUnicode(true).HasMaxLength(200);
            builder.Property(x => x.Receiver_name).IsRequired().IsUnicode(true).HasMaxLength(50);
            builder.Property(x => x.Receiver_pincode).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Receiver_phone).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Receiver_address).IsRequired().IsUnicode(true).HasMaxLength(200);

            builder.Property(x => x.Transfer_value).IsRequired();

            builder.Property(x => x.Transfer_fee).IsRequired();

            builder.Property(x => x.Total).IsRequired();

            builder.Property(x => x.Note).HasMaxLength(500);

            builder.Property(x => x.Transfer_date).IsRequired();

            builder.Property(x => x.Transfer_status).IsRequired();

            builder.Property(x => x.Sender_national_identity_number).HasMaxLength(20);

            builder.Property(x => x.Receiver_national_identity_number).HasMaxLength(20);
        }
    }
}
