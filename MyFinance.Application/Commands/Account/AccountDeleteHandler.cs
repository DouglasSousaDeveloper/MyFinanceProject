namespace MyFinance.Application.Commands.Account;

internal class AccountDeleteHandler : IRequestHandler<AccountDeleteCommand, Result>
{
    private readonly IAccountRepository _accountRepository;

    public AccountDeleteHandler(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }

    public async Task<Result> Handle(AccountDeleteCommand request, CancellationToken cancellationToken)
    {
        var account = Conta.ContaFactory.ExcluirConta(
            request.Id, request.Nome, 
            request.Cpf, request.Tipo, 
            request.IntituicaoFinanceira, request.Saldo
            );

        if (account.IsFailure)
            return Result.Failure(account.Error);

        var delete = await _accountRepository.DeleteAsync(account.Value);

        if (delete != 1)
            return Result.Failure("Erro ao deletar conta.");
        
        //TODO: impelementar o envio de email

        return Result.Success();
    }
}
