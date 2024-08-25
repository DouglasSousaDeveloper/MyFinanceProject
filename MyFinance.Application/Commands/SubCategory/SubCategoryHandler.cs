namespace MyFinance.Application.Commands.SubCategory;

internal class SubCategoryHandler : IRequestHandler<SubCategoryCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(SubCategoryCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
