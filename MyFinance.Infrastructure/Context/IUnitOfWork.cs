namespace MyFinance.Infrastructure.Context;

public interface IUnitOfWork : IDisposable
{
    IAccountRepository Account { get; }
    ICategoryRepository Category { get; }
    int Complete();
}
