using MyFinance.Core.Entities;

namespace MyFinance.Infrastructure.Interfaces;

public interface IAccountRepository
{
    Task<Conta> CreateAsync(Conta conta);
}
