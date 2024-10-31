namespace MyFinance.Application.Commands.Category;

internal class CategoryCreateHandler : IRequestHandler<CategoryCreateCommand, Result<string>>
{
    private IUnitOfWork _unitOfWork;

    public CategoryCreateHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<string>> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
    {
        var category = CategoriaTransacao.CategoriaTransacaoFactory.CriarCategoria(
            request.nome
            );

        if (category.IsFailure)
            return Result.Failure<string>(category.Error);

        await _unitOfWork.Category.AddAsync(category.Value);

        return Result.Success("Categoria criada com sucesso!");
    }
}
