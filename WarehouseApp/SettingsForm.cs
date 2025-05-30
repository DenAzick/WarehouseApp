using System.Data;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Warehouses;

namespace WarehouseApp;

public partial class SettingsForm : Form
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IUserRepository _userRepository;
    public SettingsForm(ICategoryRepository categoryRepository, IUserRepository userRepository)
    {
        InitializeComponent();
        _categoryRepository = categoryRepository;
        _userRepository = userRepository;
    }



    private async Task LoadCategories()
    {
        try
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            dataGridViewCategory.DataSource = categories;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading categories: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async Task LoadUsers()
    {
        try
        {
            var users = await _userRepository.GetAllUsersAsync();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Role", typeof(string));

            foreach (var user in users)
            {
                dataTable.Rows.Add(user.Id, user.Username, user.Role);
            }

            dataGridViewUsers.DataSource = dataTable;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void SettingsForm_Load(object sender, EventArgs e)
    {
        await LoadCategories();
        await LoadUsers();
    }

    private async void btnAddCategory_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
        {
            MessageBox.Show("Please enter a category name", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }


        try
        {
            var category = new CategoryDto
            {
                Name = txtCategoryName.Text.Trim(),
                Description = txtCategoryDescription.Text.Trim(),
                WarehouseId = 1
            };


            bool success = await _categoryRepository.AddCategoryAsync(category);

            if (success)
            {
                MessageBox.Show("Category added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear the form
                txtCategoryName.Clear();
                txtCategoryDescription.Clear();

                // Refresh the categories list
                await LoadCategories();
            }
            else
            {
                MessageBox.Show("Failed to add category", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding category: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnGetCategories_Click(object sender, EventArgs e)
    {
        try
        {
            var categories = await _categoryRepository.GetCategoriesAsync();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            foreach (var category in categories)
            {
                dataTable.Rows.Add(category.Id, category.Name, category.Description);
            }

            dataGridViewCategory.DataSource = dataTable;
            dataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading categories: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDeleteCategory_Click_1(object sender, EventArgs e)
    {

        if (dataGridViewCategory.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a category to delete", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var categoryId = (int)dataGridViewCategory.SelectedRows[0].Cells["Id"].Value;

        if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                if (await _categoryRepository.DeleteCategoryAsync(categoryId))
                {
                    MessageBox.Show("Category deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGetCategories_Click(sender, e); // Refresh the list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting category: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private async void btnGetUsers_Click(object sender, EventArgs e)
    {
        try
        {
            var users = await _userRepository.GetAllUsersAsync();

            var dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Role", typeof(string));

            foreach (var user in users)
            {
                dataTable.Rows.Add(user.Id, user.Username, user.Role);
            }

            dataGridViewUsers.DataSource = dataTable;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void btnDeleteUser_Click(object sender, EventArgs e)
    {
        if (dataGridViewCategory.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select a category to delete", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var categoryId = (int)dataGridViewCategory.SelectedRows[0].Cells["Id"].Value;

        if (MessageBox.Show("Are you sure you want to delete this category?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                if (await _categoryRepository.DeleteCategoryAsync(categoryId))
                {
                    MessageBox.Show("Category deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGetCategories_Click(sender, e); // Refresh the list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting category: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



