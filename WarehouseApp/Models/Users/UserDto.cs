﻿namespace WarehouseApp.Models.Users;

public class UserDto
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string? Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public ERoles Role { get; set; }
}
