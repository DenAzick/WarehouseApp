namespace WarehouseApp.Models.Warehouses;

public class CategoryDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }

    

    public int WarehouseId { get; set; } = 1;

}
