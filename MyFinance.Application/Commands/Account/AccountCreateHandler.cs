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
        var account = Conta.ContaFactory.CriarConta(
            request.Nome, request.Cpf,
            request.Tipo, request.IntituicaoFinanceira,
            request.Saldo
            );

        if (account.IsFailure)
            return Result.Failure(account.Error);

        await _accountRepository.CreateAsync(account.Value);

        return Result.Success();
    }
}
