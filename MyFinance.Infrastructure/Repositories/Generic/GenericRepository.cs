using Microsoft.EntityFrameworkCore;
using MyFinance.Infrastructure.Context;
using MyFinance.Infrastructure.Interfaces.Generic;

namespace MyFinance.Infrastructure.Repositories.Generic;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly MyFinanceContext _context;

    public GenericRepository(MyFinanceContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public async Task<T> CreateAsync(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Set<T>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _context.Set<T>().FindAsync(id);
        if (entity is not null)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

        }
    }
}