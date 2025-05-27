namespace WarehouseApp.Models.Users;

public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public string? Email { get; set; }
    public required string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public Roles Role {  get; set; } = Roles.Operator;

}

public enum Roles
{
    Admin,
    Manager,
    Operator
}