using Microsoft.AspNetCore.Mvc;
using ChatApp.Application.Users.CreateUser;

namespace ChatApp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController: ControllerBase
{
    private readonly CreateUserHandler _handler;

    public UsersController(CreateUserHandler handler)
    {
        _handler = handler;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateUserCommand command)
    {
        var userId = await _handler.Handle(command);
        return Ok(userId);
    }
}