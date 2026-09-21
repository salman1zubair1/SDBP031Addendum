using Microsoft.EntityFrameworkCore; 
using SDBP031Addendum.Models;

namespace SDBP031Addendum.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed your sample data
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                new Product { Id = 2, Name = "Keyboard", Price = 79.99m },
                new Product { Id = 3, Name = "Mouse", Price = 39.99m }
            );
        }
    }
}