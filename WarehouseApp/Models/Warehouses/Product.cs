namespace WarehouseApp.Models.Warehouses;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public double Measurement { get; set; }

    public EMeasurements EMeasurements { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

}

public enum EMeasurements
{
    Piece,
    Kg,
    Liter,
    Gram,
    Ton
}