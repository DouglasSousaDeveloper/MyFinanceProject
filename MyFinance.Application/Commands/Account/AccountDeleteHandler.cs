using FluentEmail.Core;
using MyFinance.Core.Utils;
using MyFinance.Infrastructure.Context;

namespace MyFinance.Application.Commands.Account;

internal class AccountDeleteHandler : IRequestHandler<AccountDeleteCommand, Result>
{
    private IUnitOfWork _unitOfWork;
    private readonly IFluentEmail _fluentEmail;

    public AccountDeleteHandler(IUnitOfWork unitOfWork, IFluentEmail fluentEmail)
    {
        _unitOfWork = unitOfWork;
        _fluentEmail = fluentEmail;
    }

    public async Task<Result> Handle(AccountDeleteCommand request, CancellationToken cancellationToken)
    {
        var accountById = await _unitOfWork.Account.GetByIdAsync(Guid.Parse(request.Id));

        if (accountById is null)
            return Result.Failure("Id não existe.");

        var account = Conta.ContaFactory.ExcluirConta(
            request.Id, request.Nome, 
            request.Cpf, request.Tipo, 
            request.IntituicaoFinanceira, request.Saldo
            );

        if (account.IsFailure)
            return Result.Failure(account.Error);

        await _unitOfWork.Account.DeleteAsync(account.Value);

        await SendEmail.Send(_fluentEmail, "douglas_vdlk&@hotmail.com", $"Sua conta no {request.IntituicaoFinanceira} foi cancelada com sucesso.");

        return Result.Success();
    }
}
