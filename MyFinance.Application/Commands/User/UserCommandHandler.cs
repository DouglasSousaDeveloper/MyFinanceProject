using CSharpFunctionalExtensions;
using MediatR;
using MyFinance.Application.ViewModels;

namespace MyFinance.Application.Commands.User;

internal class UserCommandHandler : IRequestHandler<UserCommand, Result<UserVm>>
{
    public async Task<Result<UserVm>> Handle(UserCommand request, CancellationToken cancellationToken)
    {
        UserVm user = new();
        user.nome = "Douglas";

        return Result.Success(user);
    }
}
