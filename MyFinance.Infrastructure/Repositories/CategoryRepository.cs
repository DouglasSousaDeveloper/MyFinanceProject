using MyFinance.Infrastructure.Context;
using MyFinance.Infrastructure.Repositories.Generic;

namespace MyFinance.Infrastructure.Repositories;

internal class CategoryRepository : GenericRepository<CategoriaTransacao>, ICategoryRepository
{
    public CategoryRepository(MyFinanceContext dbContext) : base(dbContext)
    {
    }
}
