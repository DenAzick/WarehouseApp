using WarehouseApp.Interfaces;
using WarehouseApp.Models.Warehouses;

namespace WarehouseApp;

public partial class EditProductForm : Form
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IProductRepository _productRepository;
    private readonly ProductDto productDto;

    public EditProductForm(IProductRepository productRepository, ICategoryRepository categoryRepository, ProductDto productDto)
    {
        InitializeComponent();
        _categoryRepository = categoryRepository;
        _productRepository = productRepository;
        this.productDto = productDto;
    }


}
