
using MyFinance.Application.ViewModels.Transaction;

namespace MyFinance.Application.Queries.Transaction;

internal class TransactionHistoryQueryHandler : IRequestHandler<TransactionHistoryQuery, Result<TransactionHistoryVm>>
{
    public Task<Result<TransactionHistoryVm>> Handle(TransactionHistoryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
