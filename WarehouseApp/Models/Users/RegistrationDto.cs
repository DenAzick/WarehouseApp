namespace WarehouseApp.Models.Users;

public class RegistrationDto
{
    public required string Username { get; set; }
    public required string Password { get; set; }
    public string? Email { get; set; }
}
