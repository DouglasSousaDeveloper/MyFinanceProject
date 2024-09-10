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
        CategoriaTransacao category = new()
        {

        };

        await _categoryRepository.CreateAsync(category);

        return Result.Success("Categoria criada com sucesso!");
    }
}
