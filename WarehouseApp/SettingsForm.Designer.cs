namespace WarehouseApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            btnAddCategory = new Button();
            txtCategoryName = new TextBox();
            lblCategoryName = new Label();
            lblDescriptionCategory = new Label();
            txtCategoryDescription = new TextBox();
            dataGridViewCategory = new DataGridView();
            btnGetCategories = new Button();
            btnGetUsers = new Button();
            btnDeleteCategory = new Button();
            btnDeleteUser = new Button();
            dataGridViewUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(470, 104);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(106, 23);
            btnAddCategory.TabIndex = 1;
            btnAddCategory.Text = "add category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(135, 62);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(281, 23);
            txtCategoryName.TabIndex = 2;
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(40, 70);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(89, 15);
            lblCategoryName.TabIndex = 3;
            lblCategoryName.Text = "name category:";
            // 
            // lblDescriptionCategory
            // 
            lblDescriptionCategory.AutoSize = true;
            lblDescriptionCategory.Location = new Point(40, 108);
            lblDescriptionCategory.Name = "lblDescriptionCategory";
            lblDescriptionCategory.Size = new Size(69, 15);
            lblDescriptionCategory.TabIndex = 5;
            lblDescriptionCategory.Text = "description:";
            // 
            // txtCategoryDescription
            // 
            txtCategoryDescription.Location = new Point(135, 100);
            txtCategoryDescription.Name = "txtCategoryDescription";
            txtCategoryDescription.Size = new Size(281, 23);
            txtCategoryDescription.TabIndex = 4;
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.Location = new Point(12, 241);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.Size = new Size(353, 308);
            dataGridViewCategory.TabIndex = 6;
            // 
            // btnGetCategories
            // 
            btnGetCategories.Location = new Point(40, 212);
            btnGetCategories.Name = "btnGetCategories";
            btnGetCategories.Size = new Size(106, 23);
            btnGetCategories.TabIndex = 7;
            btnGetCategories.Text = "Get categories";
            btnGetCategories.UseVisualStyleBackColor = true;
            btnGetCategories.Click += btnGetCategories_Click;
            // 
            // btnGetUsers
            // 
            btnGetUsers.Location = new Point(452, 212);
            btnGetUsers.Name = "btnGetUsers";
            btnGetUsers.Size = new Size(106, 23);
            btnGetUsers.TabIndex = 8;
            btnGetUsers.Text = "Get Users";
            btnGetUsers.UseVisualStyleBackColor = true;
            btnGetUsers.Click += btnGetUsers_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(208, 212);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(106, 23);
            btnDeleteCategory.TabIndex = 9;
            btnDeleteCategory.Text = "Delete category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click_1;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(634, 212);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(106, 23);
            btnDeleteUser.TabIndex = 10;
            btnDeleteUser.Text = "Delete user";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(419, 241);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(353, 308);
            dataGridViewUsers.TabIndex = 11;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(dataGridViewUsers);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnDeleteCategory);
            Controls.Add(btnGetUsers);
            Controls.Add(btnGetCategories);
            Controls.Add(dataGridViewCategory);
            Controls.Add(lblDescriptionCategory);
            Controls.Add(txtCategoryDescription);
            Controls.Add(lblCategoryName);
            Controls.Add(txtCategoryName);
            Controls.Add(btnAddCategory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            Text = "Settings Form";
            Load += SettingsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnAddCategory;
        private TextBox txtCategoryName;
        private Label lblCategoryName;
        private Label lblDescriptionCategory;
        private TextBox txtCategoryDescription;
        private DataGridView dataGridViewCategory;
        private Button btnGetCategories;
        private Button btnGetUsers;
        private Button btnDeleteCategory;
        private Button btnDeleteUser;
        private DataGridView dataGridViewUsers;
    }
}