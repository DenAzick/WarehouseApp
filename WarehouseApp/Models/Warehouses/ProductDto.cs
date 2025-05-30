namespace WarehouseApp.Models.Warehouses;

public class ProductDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Measurement { get; set; }
    public EMeasurements MeasurementType { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
