namespace MyFinance.Infrastructure.Repositories;

internal class AccountRepository : IAccountRepository
{
    public Task<IEnumerable<Conta>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Conta> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Conta> CreateAsync(Conta conta)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Conta conta)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
