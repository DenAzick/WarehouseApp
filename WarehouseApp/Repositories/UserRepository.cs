using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WarehouseApp.Context;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Users;

namespace WarehouseApp.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateUserAsync(RegistrationDto dto)
    {
        if (await _context.Users.AnyAsync(u => u.Username == dto.Username))
            return false;

        var user = new User
        {
            Username = dto.Username,
            Email = dto.Email,
            Role = ERoles.Operator,
            CreatedAt = DateTime.Now
        };

        var hasher = new PasswordHasher<User>();
        user.PasswordHash = hasher.HashPassword(user, dto.Password);

        _context.Users.Add(user);   
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<UserDto>> GetAllUsersAsync()
    {
        return await _context.Users
        .Select(u => new UserDto
        {
            Username = u.Username,
            Email = u.Email,
            Role = u.Role
        })
        .ToListAsync();
    }

    public async Task<UserDto?> GetUserByIdAsync(int id)
    {
        return await _context.Users
        .Where(u => u.Id == id)
        .Select(u => new UserDto
        {
            Username = u.Username,
            Email = u.Email,
            Role = u.Role
        })
        .FirstOrDefaultAsync();
    }

    public async Task<UserDto?> GetUserByUsernameAsync(string username)
    {
        return await _context.Users
        .Where(u => u.Username == username)
        .Select(u => new UserDto
        {
            Username = u.Username,
            Email = u.Email,
            Role = u.Role
        })
        .FirstOrDefaultAsync();
    }

    public async Task<UserDto?> LoginUserAsync(LoginDto dto)
    {
        var user = await _context.Users
        .Where(u => u.Username == dto.Username && u.PasswordHash == dto.Password)
        .Select(u => new UserDto
        {
            Username = u.Username,
            Email = u.Email,
            Role = u.Role
        })
        .FirstOrDefaultAsync();

        return user;
    }

    public async Task<bool> UpdateUserAsync(int id, RegistrationDto dto)
    {
        throw new NotImplementedException();
    }
}
