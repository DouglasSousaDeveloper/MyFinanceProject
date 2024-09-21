using Microsoft.EntityFrameworkCore;
using MyFinance.Infrastructure.Repositories.Base;

namespace MyFinance.Infrastructure.Repositories;

internal class AccountRepository : BaseRepository<Conta, DbContext>, IAccountRepository
{
    public AccountRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
