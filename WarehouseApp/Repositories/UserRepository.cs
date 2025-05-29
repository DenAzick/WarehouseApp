using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WarehouseApp.Context;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Users;

namespace WarehouseApp.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public UserRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
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
            //CreatedAt = DateTime.UtcNow
        };

        var hasher = new PasswordHasher<User>();
        user.PasswordHash = hasher.HashPassword(user, dto.Password);

        _context.Users.Add(user);   
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<List<UserDto>> GetAllUsersAsync()
    {
        //if (role == ERoles.Operator)
        //    throw new UnauthorizedAccessException("access denied");

        var users = await _context.Users.ToListAsync();
        return _mapper.Map<List<UserDto>>(users);
    }

    public async Task<UserDto?> GetUserByIdAsync(int id)
    {
        //if (role == ERoles.Operator)
        //    throw new UnauthorizedAccessException("access denied");

        var user = await _context.Users.FindAsync(id);
        if (user == null) return null;

        return _mapper.Map<UserDto>(user);
    }

    public async Task<UserDto?> GetUserByUsernameAsync(string username)
    {
        //if (role == ERoles.Operator)
        //    throw new UnauthorizedAccessException("access denied");

        var user = await _context.Users
         .FirstOrDefaultAsync(u => u.Username == username);

        if (user == null) return null;

        return _mapper.Map<UserDto>(user);
    }

    public async Task<bool> LoginUserAsync(LoginDto dto)
    {
        var user = await _context.Users
        .FirstOrDefaultAsync(u => u.Username == dto.Username);

        if (user == null) return false;

        var passwordHasher = new PasswordHasher<User>();

        var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);

        if (result != PasswordVerificationResult.Success)
            return false;

        return result == PasswordVerificationResult.Success;
    }

    public async Task<bool> UpdateUserAsync(int id, RegistrationDto dto)
    {
        var user = await _context.Users.FindAsync(id);
        if (user == null)
            return false;

        user.Username = dto.Username;
        user.Email = dto.Email;

        if (!string.IsNullOrWhiteSpace(dto.Password))
        {
            var hasher = new PasswordHasher<User>();
            user.PasswordHash = hasher.HashPassword(user, dto.Password);
        }

        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return true;
    }
}
