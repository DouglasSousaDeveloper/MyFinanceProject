
namespace MyFinance.Application.Commands.Debt;

internal class DebtUpdateHandler : IRequestHandler<DebtUpdateCommand, Result>
{
    public Task<Result> Handle(DebtUpdateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
