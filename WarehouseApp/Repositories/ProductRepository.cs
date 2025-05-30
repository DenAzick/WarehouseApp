using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WarehouseApp.Context;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Warehouses;

namespace WarehouseApp.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public ProductRepository(AppDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }


    public async Task<ProductDto?> GetByNameAsync(string name)
    {
        var product = await _context.Products
        .Include(p => p.Category).Where(p => p.Name == name)
        .Select(p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Measurement = p.Measurement,
            MeasurementType = p.EMeasurements,
            CategoryId = p.CategoryId,
            CategoryName = p.Category.Name
        }).FirstOrDefaultAsync();

        return product;
    }

    public async Task<ProductDto?> GetByIdAsync(int id)
    {
        return await _context.Products
            .Include(p => p.Category)
            .Where(p => p.Id == id)
            .Select(p => new ProductDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Measurement = p.Measurement,
                MeasurementType = p.EMeasurements,
                CategoryId = p.CategoryId,
                CategoryName = p.Category.Name
            })
            .FirstOrDefaultAsync();
    }

    public async Task<List<ProductDto>> GetAllAsync()
    {
        var products = await _context.Products
        .Include(p => p.Category)
        .ToListAsync();

        var result = products.Select(p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Measurement = p.Measurement,
            MeasurementType = p.EMeasurements,
            CategoryId = p.CategoryId,
            CategoryName = p.Category.Name
        }).ToList();

        return result;
    }

    public async Task<bool> CreateAsync(ProductDto dto)
    {
        try
        {
            var categoryExists = await _context.Categories.AnyAsync(c => c.Id == dto.CategoryId);
            if (!categoryExists)
            {
                throw new Exception("Category with given Id does not exist.");
            }
            var product = new Product
            {
                Name = dto.Name,
                Description = dto.Description,
                Measurement = dto.Measurement,
                EMeasurements = dto.MeasurementType,
                CategoryId = dto.CategoryId
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(ProductDto dto)
    {
        try
        {
            var product = await _context.Products.FindAsync(dto.Id);
            if (product == null) return false;

            product.Name = dto.Name;
            product.Description = dto.Description;
            product.Measurement = dto.Measurement;
            product.EMeasurements = dto.MeasurementType;
            product.CategoryId = dto.CategoryId;

            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
    {
        try
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return false;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }


}

