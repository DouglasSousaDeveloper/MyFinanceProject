using MyFinance.Core.Domains;
using MyFinance.Infrastructure.Interfaces;

namespace MyFinance.Infrastructure.Repositories;

internal class AccountRepository : IBaseRepository<Conta>
{
    public Task<Conta> CreateAsync(Conta entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Conta>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Conta> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Conta entity)
    {
        throw new NotImplementedException();
    }
}
