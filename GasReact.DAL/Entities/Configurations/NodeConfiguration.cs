using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GasReact.DAL.Entities.Configurations
{
    internal class NodeConfiguration : IEntityTypeConfiguration<Node>
    {
        public void Configure(EntityTypeBuilder<Node> builder)
        {
            builder.ToTable("nodes", "public");

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
