﻿using Microsoft.AspNetCore.Mvc;
using MyFinance.Application.Commands.Account.Create;

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
    public async Task<IActionResult> CreateAccount(AccountCreateCommand userCommand)
    {
        var result = await _mediator.Send(userCommand);

        if (result.IsFailure)
            return BadRequest(result.Error ?? "error");

        return Ok();
    }
}