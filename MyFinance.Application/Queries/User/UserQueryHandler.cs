using CSharpFunctionalExtensions;
using MediatR;
using MyFinance.Application.ViewModels;

namespace MyFinance.Application.Queries.User;

internal class UserQueryHandler : IRequestHandler<UserQuery, Result<UserVm>>
{
    public async Task<Result<UserVm>> Handle(UserQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
