#nullable disable

using MudTestApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MudTestApp.Data
{
    public class MudTestAppContext : DbContext
    {
        public MudTestAppContext(DbContextOptions<MudTestAppContext> options): base(options)
            { }

        public DbSet<Test> Tests { get; set; }
        public DbSet<Compound> Compounds { get; set; }

        public DbSet<TestResults> Results { get; set; }


         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().ToTable("Test");
            modelBuilder.Entity<Compound>().ToTable("Compound");
            modelBuilder.Entity<TestResults>().ToTable("TestResults");
        }
    }
}
