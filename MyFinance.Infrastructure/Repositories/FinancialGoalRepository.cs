using MyFinance.Infrastructure.Interfaces.Generic;

namespace MyFinance.Infrastructure.Repositories;

internal class FinancialGoalRepository : IFinancialGoalRepository
{
    private readonly IGenericRepository<MetaFinanceira> _genericRepository;

    public FinancialGoalRepository(IGenericRepository<MetaFinanceira> genericRepository)
    {
        _genericRepository = genericRepository;
    }

    public async Task AddAsync(MetaFinanceira metaFinanceira)
    {
        await _genericRepository.AddAsync(metaFinanceira);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _genericRepository.DeleteAsync(id);
    }
}
