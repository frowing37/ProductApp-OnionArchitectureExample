using Microsoft.EntityFrameworkCore;
using ProoductApp.Domain.Entities;

namespace ProductApp.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product(){ Id = new Guid(), Name = "Pen", Value = 10, Quantity = 100},
        new Product(){ Id = new Guid(), Name = "Paper A4", Value = 10, Quantity = 100},
        new Product(){ Id = new Guid(), Name = "Book", Value = 10, Quantity = 100}
            );
        
        base.OnModelCreating(modelBuilder);
    }
}