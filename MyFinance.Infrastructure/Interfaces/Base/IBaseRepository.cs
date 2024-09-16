namespace MyFinance.Infrastructure.Interfaces.Base;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(Guid id);
    Task<TEntity> CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(Guid id);
}
