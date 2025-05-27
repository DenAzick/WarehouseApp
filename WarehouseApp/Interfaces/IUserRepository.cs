using WarehouseApp.Models.Users;

namespace WarehouseApp.Interfaces;

public interface IUserRepository
{
    Task<bool> CreateUserAsync(RegistrationDto dto);
    Task<UserDto?> LoginUserAsync(LoginDto dto);
    Task<bool> UpdateUserAsync(int id, RegistrationDto dto);
    Task<List<UserDto>> GetAllUsersAsync();
    Task<UserDto?> GetUserByIdAsync(int id);
    Task<UserDto?> GetUserByUsernameAsync(string username);
}
