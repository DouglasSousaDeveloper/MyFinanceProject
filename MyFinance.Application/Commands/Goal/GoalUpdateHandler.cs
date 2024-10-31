
namespace MyFinance.Application.Commands.Goal;

internal class GoalUpdateHandler : IRequestHandler<GoalUpdateCommand, Result>
{
    public Task<Result> Handle(GoalUpdateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
