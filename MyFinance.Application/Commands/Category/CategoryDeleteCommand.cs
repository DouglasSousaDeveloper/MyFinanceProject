namespace MyFinance.Application.Commands.Category;

public class CategoryDeleteCommand : IRequest<Result>
{
    public Guid Id { get; set; }
}
