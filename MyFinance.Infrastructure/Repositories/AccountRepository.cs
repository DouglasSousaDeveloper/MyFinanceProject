using MyFinance.Infrastructure.Context;
using MyFinance.Infrastructure.Repositories.Generic;

namespace MyFinance.Infrastructure.Repositories;

internal class AccountRepository : GenericRepository<Conta>, IAccountRepository
{
    public AccountRepository(MyFinanceContext dbContext) : base(dbContext)
    {
    }
}
