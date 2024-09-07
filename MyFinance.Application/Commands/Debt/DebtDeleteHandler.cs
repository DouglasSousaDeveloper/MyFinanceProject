namespace MyFinance.Application.Commands.Debt;

internal class DebtDeleteHandler : IRequestHandler<DebtDeleteCommand, Result>
{
    public Task<Result> Handle(DebtDeleteCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
