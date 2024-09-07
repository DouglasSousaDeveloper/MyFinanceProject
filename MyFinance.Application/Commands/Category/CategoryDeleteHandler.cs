
namespace MyFinance.Application.Commands.Category;

internal class CategoryDeleteHandler : IRequestHandler<CategoryDeleteCommand, Result>
{
    public Task<Result> Handle(CategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
