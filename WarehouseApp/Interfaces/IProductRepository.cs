using WarehouseApp.Models.Warehouses;

namespace WarehouseApp.Interfaces;

public interface IProductRepository
{
    Task<ProductDto> GetByNameAsync(string name);
    Task<ProductDto> GetByIdAsync(int id);
    Task<List<ProductDto>> GetAllAsync();
    Task<bool> CreateAsync(ProductDto product);
    //Task<bool> UpdateAsync(ProductDto product);
    Task<bool> DeleteAsync(int id);
}
