﻿namespace MyFinance.Application.Commands.Category;

internal class CategoryCreateHandler : IRequestHandler<CategoryCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
