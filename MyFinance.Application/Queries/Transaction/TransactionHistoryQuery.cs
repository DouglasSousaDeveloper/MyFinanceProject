using MyFinance.Application.ViewModels.Transaction;

namespace MyFinance.Application.Queries.Transaction;

public class TransactionHistoryQuery : IRequest<Result<TransactionHistoryDto>>
{
}
