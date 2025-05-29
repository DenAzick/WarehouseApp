using Microsoft.EntityFrameworkCore;
using WarehouseApp.Models.Users;
using WarehouseApp.Models.Warehouses;

namespace WarehouseApp.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<User>()
        //.Property(u => u.CreatedAt)
        //.HasColumnType("timestamp with time zone")
        //.HasDefaultValueSql("now()");

        modelBuilder.Entity<User>()
        .Property(u => u.Role)
        .HasConversion<string>();

        modelBuilder.Entity<User>()
        .HasIndex(u => u.Username)
        .IsUnique();

        //modelBuilder.Entity<User>()
        //.HasIndex(u => u.Email)
        //.IsUnique();


        modelBuilder.Entity<Warehouse>()
        .HasMany(w => w.Categories)
        .WithOne(c => c.Warehouse)
        .HasForeignKey(c => c.WarehouseId)
        .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Category>()
        .HasMany(c => c.Products)
        .WithOne(p => p.Category)
        .HasForeignKey(p => p.CategoryId)
        .OnDelete(DeleteBehavior.Cascade);
    }
}
