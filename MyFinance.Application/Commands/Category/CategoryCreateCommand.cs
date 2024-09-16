namespace MyFinance.Application.Commands.Category;

public class CategoryCreateCommand : IRequest<Result<string>>
{
    public string nome { get; set; }
}
