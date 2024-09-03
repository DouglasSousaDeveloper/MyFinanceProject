namespace MyFinance.Application.Commands.Account;

public class AccountUpdateCommand : IRequest<Result>
{
    public string CPF { get; set; }
}
