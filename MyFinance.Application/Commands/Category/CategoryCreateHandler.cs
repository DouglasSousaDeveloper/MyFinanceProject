using MyFinance.Core.Domains;
using MyFinance.Infrastructure.Interfaces;

namespace MyFinance.Application.Commands.Category;

internal class CategoryCreateHandler : IRequestHandler<CategoryCreateCommand, Result<string>>
{
    public readonly ICategoryRepository _categoryRepository;

    public CategoryCreateHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<Result<string>> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
    {
        var category = CategoriaTransacao.CategoriaTransacaoFactory.CriarCategoria(
            request.nome
            );

        if (category.IsFailure)
            return Result.Failure<string>(category.Error);

        await _categoryRepository.CreateAsync(category.Value);

        return Result.Success("Categoria criada com sucesso!");
    }
}
