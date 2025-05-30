using WarehouseApp.Models.Warehouses;

namespace WarehouseApp.Interfaces;

public interface ICategoryRepository
{
    Task<List<CategoryDto?>> GetCategoriesAsync();

    Task<bool> AddCategoryAsync(CategoryDto category);
    Task<bool> UpdateCategoryAsync(int id, CategoryDto dto);
    Task<bool> DeleteCategoryAsync(int id);
    Task<CategoryDto?> GetCategoryByNameAsync(string name);
}
