using Microsoft.EntityFrameworkCore;
using WarehouseApp.Models.Users;

namespace WarehouseApp.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .Property(u => u.Role)
        .HasConversion<string>();
    }


}
