using ExpoSoft.Domain.Entities;
using ExpoSoft.Infrastructure.Data.Base;
using Microsoft.EntityFrameworkCore;

namespace ExpoSoft.Infrastructure.Data
{
    public class ExpoSoftContext : DbContextBase
    {
        public ExpoSoftContext(DbContextOptions options) : base(options) { }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<HistoricalScore> HistoricalScores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Business>().HasKey(ent => ent.Id);
            modelBuilder.Entity<Score>().HasKey(ent => ent.Id);
        }
    }
}
