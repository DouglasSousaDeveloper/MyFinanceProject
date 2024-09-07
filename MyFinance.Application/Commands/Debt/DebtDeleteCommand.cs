namespace MyFinance.Application.Commands.Debt;

public class DebtDeleteCommand : IRequest<Result>
{
    public Guid Id { get; set; }
}
