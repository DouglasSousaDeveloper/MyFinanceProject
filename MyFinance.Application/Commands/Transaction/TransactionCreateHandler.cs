namespace MyFinance.Application.Commands.Transaction;

internal class TransactionCreateHandler : IRequestHandler<TransactionCommand, Result<string>>
{
    public async Task<Result<string>> Handle(TransactionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
