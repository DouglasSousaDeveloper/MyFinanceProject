namespace MyFinance.Api.Configuration;

public class BaseConfigController : ControllerBase
{
    private readonly IMediator _mediator;

    public BaseConfigController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        return _mediator.Send(request, cancellationToken);
    }
}
