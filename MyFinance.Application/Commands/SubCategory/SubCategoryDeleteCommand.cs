namespace MyFinance.Application.Commands.SubCategory;

public class SubCategoryDeleteCommand : IRequest<Result>
{
    public Guid Id { get; set; }
}
