using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarehouseApp.Models.Users;

public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public string? Email { get; set; }
    public string PasswordHash { get; set; }

    //[Column(TypeName = "timestamp with time zone")]
    //public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }

    public ERoles Role { get; set; } = ERoles.Operator;

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