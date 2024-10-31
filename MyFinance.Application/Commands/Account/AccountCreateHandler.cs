using MyFinance.Infrastructure.Context;

namespace MyFinance.Application.Commands.Account;

internal class AccountCreateHandler : IRequestHandler<AccountCreateCommand, Result>
{
    private IUnitOfWork _unitOfWork;

    public AccountCreateHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
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

        await _unitOfWork.Account.AddAsync(account.Value);

        return Result.Success();
    }
}
