namespace MyFinance.Infrastructure.Interfaces;

public interface IAccountRepository
{
    Task<Conta> CreateAsync(Conta conta);
    Task<int> DeleteAsync(Guid id);
}
