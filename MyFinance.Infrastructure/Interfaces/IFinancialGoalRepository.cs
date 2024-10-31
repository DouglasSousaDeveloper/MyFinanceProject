namespace MyFinance.Infrastructure.Interfaces;

public interface IFinancialGoalRepository
{
    Task AddAsync(MetaFinanceira metaFinanceira);
    Task DeleteAsync(Guid id);
}
