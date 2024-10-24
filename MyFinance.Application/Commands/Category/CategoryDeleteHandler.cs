
namespace MyFinance.Application.Commands.Category;

internal class CategoryDeleteHandler : IRequestHandler<CategoryDeleteCommand, Result>
{
    private IUnitOfWork _unitOfWork;

    public CategoryDeleteHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<Result> Handle(CategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
