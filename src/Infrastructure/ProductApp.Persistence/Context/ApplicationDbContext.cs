using Microsoft.EntityFrameworkCore;
using ProoductApp.Domain.Entities;

namespace ProductApp.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product(){ Id = Guid.NewGuid(), Name = "Pen", Value = 10, Quantity = 100},
            new Product(){ Id = Guid.NewGuid(), Name = "Paper A4", Value = 10, Quantity = 100},
            new Product(){ Id = Guid.NewGuid(), Name = "Book", Value = 10, Quantity = 100}
            );
        
        base.OnModelCreating(modelBuilder);
    }
}