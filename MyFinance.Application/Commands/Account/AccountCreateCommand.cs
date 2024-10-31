namespace MyFinance.Application.Commands.Account;

public class AccountCreateCommand : IRequest<Result>
{
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Tipo { get; set; }
    public string IntituicaoFinanceira { get; set; }
    public decimal Saldo { get; set; }
}
