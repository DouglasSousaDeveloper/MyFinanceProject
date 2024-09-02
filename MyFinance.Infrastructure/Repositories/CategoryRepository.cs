using MyFinance.Core.Domains;
using MyFinance.Infrastructure.Interfaces;

namespace MyFinance.Infrastructure.Repositories;

internal class CategoryRepository : IBaseRepository<CategoriaTransacao>
{
    public Task<CategoriaTransacao> CreateAsync(CategoriaTransacao entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CategoriaTransacao>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CategoriaTransacao> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(CategoriaTransacao entity)
    {
        throw new NotImplementedException();
    }
}
