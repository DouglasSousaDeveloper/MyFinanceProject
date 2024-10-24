namespace MyFinance.Infrastructure.Context;

internal class UnitOfWork : IUnitOfWork
{
    private readonly MyFinanceContext _context;

    public IAccountRepository Account { get; }

    public ICategoryRepository Category { get; }

    public UnitOfWork(MyFinanceContext context,
                      IAccountRepository accountRepository,
                      ICategoryRepository categoryRepository)
    {
        _context = context;
        Account = accountRepository;
        Category = categoryRepository;
    }

    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
    }
}
