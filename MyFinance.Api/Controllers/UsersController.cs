using MyFinance.Application.Commands.User;

namespace MyFinance.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;

    public UsersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser(UserCreateCommand userCommand)
    {
        var result = await _mediator.Send(userCommand);

        if (result.IsFailure)
            return BadRequest(result.Error ?? "error");

        return Ok();
    }
}
