namespace MyFinance.Application.Commands.Account.Create;

public class AccountCreateCommand : IRequest<Result<string>>
{
    public string CPF { get; set; }
}
