namespace MyFinance.Application.Commands.Account;

internal class AccountCreateHandler : IRequestHandler<AccountCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(AccountCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
