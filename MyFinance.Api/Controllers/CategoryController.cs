using MyFinance.Api.Configuration;
using MyFinance.Application.Commands.Category;

namespace MyFinance.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : BaseConfigController
{
    public CategoryController(IMediator mediator) : base(mediator)
    {
            
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CategoryCreateCommand command)
    {
        var result = await Send(command);
        return Ok(result);
    }
}
