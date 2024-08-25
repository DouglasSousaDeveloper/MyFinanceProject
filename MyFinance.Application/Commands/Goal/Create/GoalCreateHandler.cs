namespace MyFinance.Application.Commands.Goal.Create;

internal class GoalCreateHandler : IRequestHandler<GoalCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(GoalCreateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
