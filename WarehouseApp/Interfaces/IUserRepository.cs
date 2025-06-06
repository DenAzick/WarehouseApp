﻿using WarehouseApp.Models.Users;

namespace WarehouseApp.Interfaces;

public interface IUserRepository
{
    Task<bool> CreateUserAsync(RegistrationDto dto);
    Task<bool> LoginUserAsync(LoginDto dto);
    Task<bool> UpdateUserAsync(int id, RegistrationDto dto);
    Task<List<UserDto>> GetAllUsersAsync();
    Task<UserDto?> GetUserByIdAsync(int id);
    Task<UserDto?> GetUserByUsernameAsync(string username);
    Task<bool> DeleteUserAsync(int id);
}
