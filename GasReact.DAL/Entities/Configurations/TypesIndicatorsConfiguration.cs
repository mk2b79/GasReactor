using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GasReact.DAL.Entities.Configurations
{
    internal class TypesIndicatorsConfiguration : IEntityTypeConfiguration<TypesIndicators>
    {
        public void Configure(EntityTypeBuilder<TypesIndicators> builder)
        {
            builder.ToTable("types_indicators", "public");

            builder.HasKey(it => it.TypeId);
            builder.Property(it => it.TypeId)
                .HasColumnName("type_id")
                .UseIdentityColumn();

            builder.Property(it => it.TypeName)
                .HasColumnName("type_name")
                .IsRequired();

            builder.HasMany(it => it.Indicators)
                .WithOne(i => i.Type)
                .HasForeignKey(i => i.TypeId);
        }
    }
}
