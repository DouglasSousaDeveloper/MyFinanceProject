namespace MyFinance.Application.Commands.SubCategory;

internal class SubCategoryDeleteHandler : IRequestHandler<SubCategoryDeleteCommand, Result>
{
    public Task<Result> Handle(SubCategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
