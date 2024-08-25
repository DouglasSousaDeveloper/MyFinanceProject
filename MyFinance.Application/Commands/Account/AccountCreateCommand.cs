namespace MyFinance.Application.Commands.Account;

public class AccountCreateCommand : IRequest<Result<string>>
{
    public string CPF { get; set; }
}
