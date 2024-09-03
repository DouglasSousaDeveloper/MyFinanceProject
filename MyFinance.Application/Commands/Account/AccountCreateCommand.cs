namespace MyFinance.Application.Commands.Account;

public class AccountCreateCommand : IRequest<Result>
{
    public string CPF { get; set; }
}
