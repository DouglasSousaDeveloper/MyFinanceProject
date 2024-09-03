using Microsoft.Extensions.DependencyInjection;
using MyFinance.Core.Domains;
using MyFinance.Infrastructure.Interfaces;

namespace MyFinance.Application.Commands.Account;

internal class AccountCreateHandler : IRequestHandler<AccountCreateCommand, Result>
{
    private readonly IAccountRepository _accountRepository;

    public AccountCreateHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Result> Handle(AccountCreateCommand request, CancellationToken cancellationToken)
    {
        Conta account = new()
        {

        };

        await _accountRepository.CreateAsync(account);

        return Result.Success();
    }
}
