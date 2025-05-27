using System.ComponentModel.DataAnnotations;

namespace WarehouseApp.Models.Users;

public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public string? Email { get; set; }
    public string PasswordHash { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? DeletedAt { get; set; }

    public ERoles Role {  get; set; } = ERoles.Operator;

}

public enum ERoles
{
    [Display(Name = "Admin")]
    Admin,

    [Display(Name = "Manager")]
    Manager,

    [Display(Name = "Operator")]
    Operator
}