using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProoductApp.Domain.Entities;

namespace ProductApp.Persistence.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductService
{
    public ProductRepository(ApplicationDbContext dbContext) : base(dbContext) { }
}