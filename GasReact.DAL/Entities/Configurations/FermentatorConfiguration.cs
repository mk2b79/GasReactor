using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GasReact.DAL.Entities.Configurations
{
    internal class FermentatorConfiguration : IEntityTypeConfiguration<Fermentator>
    {
        public void Configure(EntityTypeBuilder<Fermentator> builder)
        {
            builder.ToTable("fermentators","public");

            builder.HasKey(f=>f.Id);
            builder.Property(f=>f.Id)
                .HasColumnName("fermentator_id")
                .UseIdentityColumn();

            builder.Property(f => f.FermentatorName)
                .HasColumnName("fermentator_name")
                .IsRequired();

            builder.HasMany(f => f.Records)
                .WithOne(rec => rec.Fermentator)
                .HasForeignKey(rec => rec.FermentatorId);
        }
    }
}
