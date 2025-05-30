using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using WarehouseApp.Context;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Users;

namespace WarehouseApp
{
    public partial class MainForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IServiceProvider _serviceProvider;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public MainForm(AppDbContext context, IUserRepository userRepository, IServiceProvider serviceProvider, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _serviceProvider = serviceProvider;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }


        private async void ReadProducts()
        {
            try
            {
                var products = await _productRepository.GetAllAsync();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("Category", typeof(string));
                dataTable.Columns.Add("Description", typeof(string));
                dataTable.Columns.Add("Measurement", typeof(double));
                dataTable.Columns.Add("MeasurementType", typeof(string));

                foreach (var product in products)
                {
                    dataTable.Rows.Add(
                        product.Id,
                        product.Name,
                        //product.CategoryName,
                        product.Description,
                        product.Measurement,
                        product.MeasurementType.ToString());
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error loading products: {ex.Message}", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }




        private async void MainForm_Load(object sender, EventArgs e)
        {
            ReadProducts();

            //lblUsername.Text = $"Имя: {_userDto.Username}";
            //lblRole.Text = $"Роль: {_userDto.Role}";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var addForm = new AddProductForm(_productRepository, _categoryRepository);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                ReadProducts();
            }
        }

        private async void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var productId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;
            var product = await _productRepository.GetByIdAsync(productId);

            if (product != null)
            {
                var editForm = new EditProductForm(_productRepository, _categoryRepository, product);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    ReadProducts();
                }
            }
        }

        private async void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;

            var productId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

            if (MessageBox.Show("Вы уверены, что хотите удалить этот продукт?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (await _productRepository.DeleteAsync(productId))
                {
                    MessageBox.Show("Продукт успешно удален", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadProducts();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить продукт", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize the SettingsForm with required repositories
                var settingsForm = new SettingsForm(_categoryRepository, _userRepository);

                // Set the main form as owner to maintain proper parent-child relationship
                settingsForm.StartPosition = FormStartPosition.CenterParent;

                // Show the form as a modal dialog
                if (settingsForm.ShowDialog(this) == DialogResult.OK)
                {
                    // Refresh any necessary data when settings are updated
                    ReadProducts(); // Refresh product list if categories were modified

                    // Optional: Show confirmation message
                    MessageBox.Show("Settings updated successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur during form initialization
                MessageBox.Show($"Error opening settings: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
