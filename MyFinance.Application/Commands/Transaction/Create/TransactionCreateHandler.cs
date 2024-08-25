namespace MyFinance.Application.Commands.Transaction.Create;

internal class TransactionCreateHandler : IRequestHandler<TransactionCommand, Result<string>>
{
    public async Task<Result<string>> Handle(TransactionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
