namespace MyFinance.Application.Commands.User.Create;

internal class UserCreateHandler : IRequestHandler<UserCreateCommand, Result<UserVm>>
{
    public async Task<Result<UserVm>> Handle(UserCreateCommand request, CancellationToken cancellationToken)
    {
        UserVm user = new();
        user.nome = "Douglas";

        return Result.Success(user);
    }
}
