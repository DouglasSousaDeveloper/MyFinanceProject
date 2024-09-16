using Microsoft.EntityFrameworkCore;
using MyFinance.Infrastructure.Interfaces;
using MyFinance.Infrastructure.Repositories.Base;

namespace MyFinance.Infrastructure.Repositories;

internal class CategoryRepository : BaseRepository<CategoriaTransacao, DbContext>, ICategoryRepository
{
    public CategoryRepository(DbContext dbContext) : base(dbContext)
    {
    }
}
