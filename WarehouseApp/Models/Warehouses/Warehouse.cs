namespace WarehouseApp.Models.Warehouses;

public class Warehouse
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    public List<Category> Categories { get; set; } = new List<Category>();
}
