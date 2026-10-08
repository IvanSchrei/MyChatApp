using ChatApp.Application.Interfaces;
using ChatApp.Infrastructure.Persistence;
using ChatApp.Domain.Entities;

namespace ChatApp.Infrastructure.Persistence.Repositories;
public class UserRepository: IUserRepository
{
    private readonly ChatAppDbContext _context;

    public UserRepository(ChatAppDbContext context)
    {
        _context = context;
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        return await _context.Users.FindAsync();
    }

    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }
}