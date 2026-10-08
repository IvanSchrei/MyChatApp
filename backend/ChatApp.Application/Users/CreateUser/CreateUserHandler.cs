using ChatApp.Application.Interfaces;
using ChatApp.Domain.Entities;

namespace ChatApp.Application.Users.CreateUser;
public class CreateUserHandler
{
    private readonly IUserRepository _users;

    public CreateUserHandler(IUserRepository users)
    {
        _users = users;
    }

    public async Task<Guid> Handle(CreateUserCommand command)
    {
        var user = new User(
            Guid.NewGuid(),
            command.Username
        );

        await _users.AddAsync(user);

        return user.Id;
    }
}