﻿namespace MyFinance.Application.Commands.Debt;

internal class DebtCreateHandler : IRequestHandler<DebtCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DebtCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
