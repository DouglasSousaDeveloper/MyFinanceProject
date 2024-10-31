using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;
using MyFinance.Infrastructure.Context;
using MyFinance.Infrastructure.Interfaces.Generic;
using System.Linq.Expressions;

namespace MyFinance.Infrastructure.Repositories.Generic;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
{
    public readonly DbSet<T> _DbSet;
    protected readonly MyFinanceContext _context;

    public GenericRepository(MyFinanceContext context)
    {
        _DbSet = _context.Set<T>();
        _context = context;
    }

    public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
    {
        var query = _DbSet.AsQueryable();

        if (filter != null)
            query = query
                .Where(filter)
                .AsNoTracking();

        return await query.ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _DbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _DbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _DbSet.Update(entity);
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