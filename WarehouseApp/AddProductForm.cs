using System.Xml.Linq;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Warehouses;

namespace WarehouseApp;

public partial class AddProductForm : Form
{

    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public AddProductForm(IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        InitializeComponent();
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;

        InitializeFormComponents();
    }

    private async void InitializeFormComponents()
    {
        cmbMeasurementType.DataSource = Enum.GetValues(typeof(EMeasurements));
        cmbMeasurementType.DropDownStyle = ComboBoxStyle.DropDownList;

        try
        {
            // Load categories
            var categories = await _categoryRepository.GetCategoriesAsync();

            // Create a new BindingSource
            var bindingSource = new BindingSource();

            // Set the data source
            bindingSource.DataSource = categories;

            // Configure the ComboBox
            cmbCategory.DataSource = bindingSource;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading categories: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Fallback to empty list
            cmbCategory.DataSource = new List<Category>();
            cmbCategory.Text = "No categories available";
        }
    }

    private async void btnSave_Click(object sender, EventArgs e)
    {
        if (!ValidateInput())
            return;

        try
        {
            var productDto = new ProductDto
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Measurement = double.Parse(txtMeasurement.Text),
                MeasurementType = (EMeasurements)cmbMeasurementType.SelectedItem,
                CategoryId = (int)cmbCategory.SelectedValue
            };

            var result = await _productRepository.CreateAsync(productDto);

            if (result)
            {
                MessageBox.Show("Product added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Failed to add product.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding product: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private bool ValidateInput()
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Please enter product name", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (!double.TryParse(txtMeasurement.Text, out var measurement) || measurement <= 0)
        {
            MessageBox.Show("Please enter a valid positive measurement value", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        if (cmbCategory.SelectedItem == null)
        {
            MessageBox.Show("Please select a category", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        return true;
    }
}

