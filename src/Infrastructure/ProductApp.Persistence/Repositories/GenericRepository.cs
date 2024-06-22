using Microsoft.EntityFrameworkCore;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProoductApp.Domain.Common;

namespace ProductApp.Persistence.Repositories;

public class GenericRepository<T> : IGenericService<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _dbContext;

    public GenericRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<T>> GetAllAsync()
    {
        var all = await _dbContext.Set<T>().ToListAsync();
        return all;
    }

    public async Task<T> GetByIdAsync(Guid Id)
    {
        var value = await _dbContext.Set<T>().FindAsync(Id);
        return value;
    }

    public async Task<T> AddAsync(T Entity)
    {
        await _dbContext.Set<T>().AddAsync(Entity);
        await _dbContext.SaveChangesAsync();
        return Entity;
    }
}