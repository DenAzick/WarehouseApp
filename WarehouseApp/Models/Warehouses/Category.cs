namespace WarehouseApp.Models.Warehouses;

public class Category
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public int WarehouseId { get; set; }
    public Warehouse Warehouse { get; set; } = null!;

    public List<Product> Products { get; set; } = new List<Product>();

}
