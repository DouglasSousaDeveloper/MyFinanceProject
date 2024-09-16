using Microsoft.EntityFrameworkCore;

namespace MyFinance.Infrastructure.Repositories.Base;

public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity> 
    where TEntity : class 
    where TContext : DbContext
{
    protected readonly TContext _dbContext;

    public BaseRepository(TContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbContext.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        return await _dbContext.Set<TEntity>().FindAsync(id);
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _dbContext.Set<TEntity>().Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await _dbContext.Set<TEntity>().FindAsync(id);
        if (entity is not null)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();

        }
    }
}
