namespace WarehouseApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridView();
            btnAddProduct = new Button();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            btnSettings = new Button();
            pictureBox1 = new PictureBox();
            lblUsername = new Label();
            lblRole = new Label();
            btnSearch = new Button();
            textBox1 = new TextBox();
            lblSortBy = new Label();
            domainUpDown1 = new DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(309, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1029, 567);
            dataGridView1.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(75, 290);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(128, 47);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Add product";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(75, 377);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(128, 47);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "Edit product";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(75, 470);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(128, 47);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Location = new Point(75, 563);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(128, 47);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(100, 200);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 15);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "username";
            lblUsername.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(100, 250);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(27, 15);
            lblRole.TabIndex = 7;
            lblRole.Text = "role";
            lblRole.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSearch.Location = new Point(1263, 627);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(1016, 627);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 9;
            // 
            // lblSortBy
            // 
            lblSortBy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSortBy.AutoSize = true;
            lblSortBy.Location = new Point(323, 631);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(47, 15);
            lblSortBy.TabIndex = 11;
            lblSortBy.Text = "Sort by:";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            domainUpDown1.Items.Add("id");
            domainUpDown1.Items.Add("name");
            domainUpDown1.Items.Add("category");
            domainUpDown1.Items.Add("date");
            domainUpDown1.Location = new Point(381, 627);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(126, 23);
            domainUpDown1.TabIndex = 12;
            domainUpDown1.Text = "select";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(domainUpDown1);
            Controls.Add(lblSortBy);
            Controls.Add(textBox1);
            Controls.Add(btnSearch);
            Controls.Add(lblRole);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox1);
            Controls.Add(btnSettings);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Warehouse";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAddProduct;
        private Button btnEditProduct;
        private Button btnDeleteProduct;
        private Button btnSettings;
        private PictureBox pictureBox1;
        private Label lblUsername;
        private Label lblRole;
        private Button btnSearch;
        private TextBox textBox1;
        private Label lblSortBy;
        private DomainUpDown domainUpDown1;
    }
}
