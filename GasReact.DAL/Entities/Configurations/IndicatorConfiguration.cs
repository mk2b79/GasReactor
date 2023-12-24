using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GasReact.DAL.Entities.Configurations
{
    internal class IndicatorConfiguration : IEntityTypeConfiguration<Indicator>
    {
        public void Configure(EntityTypeBuilder<Indicator> builder)
        {
            builder.ToTable("indicators", "public");

            builder.HasKey(i => i.IndicatorId);
            builder.Property(i => i.IndicatorId)
                .HasColumnName("indicator_id")
                .UseIdentityColumn();

            builder.Property(i => i.Value)
                .HasColumnName("value")
                .IsRequired();

            builder.Property(i => i.Date)
                .HasColumnName("date")
                .IsRequired();

            builder.Property(i => i.TypeId)
                .HasColumnName("type_id")
                .IsRequired();

            builder.Property(i=>i.RecordId)
                .HasColumnName("record_id")
                .IsRequired();
        }
    }
}
