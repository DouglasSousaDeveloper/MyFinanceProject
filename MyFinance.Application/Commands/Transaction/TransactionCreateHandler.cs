namespace MyFinance.Application.Commands.Transaction;

internal class TransactionCreateHandler : IRequestHandler<TransactionCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(TransactionCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
