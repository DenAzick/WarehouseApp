using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WarehouseApp.Context;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Warehouses;

namespace WarehouseApp.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;
    public CategoryRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
        SeedData();
    }




    private async void SeedData()
    {
        _context.Warehouses.Add(new Warehouse
        {
            Name = "Main warehouse"
        });
        await _context.SaveChangesAsync();
    }


    public async Task<bool> AddCategoryAsync(CategoryDto dto)
    {
        if (await _context.Categories.AnyAsync(u => u.Name == dto.Name))
            return false;

        // Проверка: существует ли такой склад
        var warehouse = await _context.Warehouses.FirstOrDefaultAsync(w => w.Id == dto.WarehouseId);
        if (warehouse == null)
            throw new Exception("Invalid WarehouseId");

        var category = new Category
        {
            Name = dto.Name,
            Description = dto.Description,
            WarehouseId = dto.WarehouseId
        };

        _context.Categories.Add(category);

        try
        {
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    public async Task<bool> DeleteCategoryAsync(int id)
    {
        try
        {
            var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);

            if (category == null) return false;

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<List<CategoryDto?>> GetCategoriesAsync()
    {
        var categoriesList = await _context.Categories.Select(c => new CategoryDto
        {
            Name= c.Name,
            Description= c.Description
        }).ToListAsync();
        return categoriesList;
    }

    public async Task<CategoryDto?> GetCategoryByNameAsync(string name)
    {
        var category = await _context.Categories
        .Where(c => c.Name == name)
        .Select(c => new CategoryDto
        {
            Name = c.Name,
            Description = c.Description
        })
        .FirstOrDefaultAsync();

        return category;
    }

    public async Task<bool> UpdateCategoryAsync(int id, CategoryDto dto)
    {
        var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);

        if (category == null) return false;

        try
        {
            category.Name = dto.Name;
            category.Description = dto.Description;

            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

}
