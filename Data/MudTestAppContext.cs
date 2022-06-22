#nullable disable
using Microsoft.AspNetCore.Identity;
using MudTestApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MudTestApp.Data
{
    //public class MudTestAppContext : DbContext
    public class MudTestAppContext : IdentityDbContext
    {
        public MudTestAppContext(DbContextOptions<MudTestAppContext> options): base(options)
            { }

        public DbSet<Test> Tests { get; set; }

        public DbSet<Customer> Customers { get; set; }  

        public DbSet<Compound> Compounds { get; set; }

        public DbSet<TestResults> Results { get; set; }


         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Test>().ToTable("Test");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Compound>().ToTable("Compound");
            modelBuilder.Entity<TestResults>().ToTable("TestResults");
                

        }
    }
}
