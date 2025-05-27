namespace WarehouseApp.Models.Users;

public class UserDto
{
    public string Username { get; set; }
    public string? Email { get; set; }
    public ERoles Role { get; set; }
}
