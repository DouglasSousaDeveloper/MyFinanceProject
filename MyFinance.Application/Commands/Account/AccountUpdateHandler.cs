
namespace MyFinance.Application.Commands.Account;

internal class AccountUpdateHandler : IRequestHandler<AccountUpdateCommand, Result>
{
    public Task<Result> Handle(AccountUpdateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
