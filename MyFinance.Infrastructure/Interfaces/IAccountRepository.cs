using MyFinance.Core.Domains;

namespace MyFinance.Infrastructure.Interfaces;

public interface IAccountRepository
{
    Task<Conta> CreateAsync(Conta conta);
}
