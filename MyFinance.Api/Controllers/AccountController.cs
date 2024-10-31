using MyFinance.Application.Commands.Account;

namespace MyFinance.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ControllerBase
{
    private readonly IMediator _mediator;

    public AccountController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateAccount(AccountCreateCommand createCommand)
    {
        var result = await _mediator.Send(createCommand);

        if (result.IsFailure)
            return BadRequest(result.Error ?? "error");

        return Ok();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteAccount(AccountDeleteCommand deleteCommand)
    {
        var result = await _mediator.Send(deleteCommand);

        if(result.IsFailure)
            return BadRequest(result.Error ?? "error");

        return NoContent();
    }
}
