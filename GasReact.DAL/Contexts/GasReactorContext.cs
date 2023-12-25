using System.Reflection;
using GasReact.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GasReact.DAL.Contexts
{
    public class GasReactorContext:DbContext
    {
        // public GasReactorContext(DbContextOptions<GasReactorContext> options):base(options)
        // {}

        public DbSet<Fermentator>? Fermentators { get; set; }
        public DbSet<Record>? Records { get; set; }
        public DbSet<TypesIndicators>? IndicatorTypes { get; set; }
        public DbSet<Indicator>? Indicators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=GasReact.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
