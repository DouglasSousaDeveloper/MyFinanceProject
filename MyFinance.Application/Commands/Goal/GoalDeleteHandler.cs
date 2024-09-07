namespace MyFinance.Application.Commands.Goal;

internal class GoalDeleteHandler : IRequestHandler<GoalDeleteCommand, Result>
{
    public Task<Result> Handle(GoalDeleteCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
