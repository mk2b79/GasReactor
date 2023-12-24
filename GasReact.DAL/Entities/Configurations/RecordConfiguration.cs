using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GasReact.DAL.Entities.Configurations
{
    internal class RecordConfiguration : IEntityTypeConfiguration<Record>
    {
        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder.ToTable("records", "public");

            builder.HasKey(r => r.RecordId);
            builder.Property(r => r.RecordId)
                .HasColumnName("record_id")
                .UseIdentityColumn();

            builder.Property(r => r.FermentatorId)
                .HasColumnName("fermentator_id")
                .IsRequired();

            builder.HasMany(r => r.Indicators)
                .WithOne(i => i.Record)
                .HasForeignKey(i => i.RecordId);
        }
    }
}
