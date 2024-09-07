
using MyFinance.Application.ViewModels.Transaction;

namespace MyFinance.Application.Queries.Transaction;

internal class TransactionHistoryQueryHandler : IRequestHandler<TransactionHistoryQuery, Result<TransactionHistoryDto>>
{
    public Task<Result<TransactionHistoryDto>> Handle(TransactionHistoryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
