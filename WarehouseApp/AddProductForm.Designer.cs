namespace WarehouseApp
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            btnSave = new Button();
            lblName = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtMeasurement = new TextBox();
            lblMeasurement = new Label();
            lblMeasurementType = new Label();
            lblCategory = new Label();
            cmbMeasurementType = new ComboBox();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(631, 457);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(75, 105);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Product name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(259, 97);
            txtName.Name = "txtName";
            txtName.Size = new Size(256, 23);
            txtName.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(259, 155);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(256, 23);
            txtDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(75, 163);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description:";
            // 
            // txtMeasurement
            // 
            txtMeasurement.Location = new Point(259, 219);
            txtMeasurement.Name = "txtMeasurement";
            txtMeasurement.Size = new Size(256, 23);
            txtMeasurement.TabIndex = 6;
            // 
            // lblMeasurement
            // 
            lblMeasurement.AutoSize = true;
            lblMeasurement.Location = new Point(75, 227);
            lblMeasurement.Name = "lblMeasurement";
            lblMeasurement.Size = new Size(83, 15);
            lblMeasurement.TabIndex = 5;
            lblMeasurement.Text = "Measurement:";
            // 
            // lblMeasurementType
            // 
            lblMeasurementType.AutoSize = true;
            lblMeasurementType.Location = new Point(75, 286);
            lblMeasurementType.Name = "lblMeasurementType";
            lblMeasurementType.Size = new Size(110, 15);
            lblMeasurementType.TabIndex = 7;
            lblMeasurementType.Text = "Measurement Type:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(75, 356);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Category:";
            // 
            // cmbMeasurementType
            // 
            cmbMeasurementType.FormattingEnabled = true;
            cmbMeasurementType.Location = new Point(259, 286);
            cmbMeasurementType.Name = "cmbMeasurementType";
            cmbMeasurementType.Size = new Size(256, 23);
            cmbMeasurementType.TabIndex = 11;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(259, 348);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(256, 23);
            cmbCategory.TabIndex = 12;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(cmbCategory);
            Controls.Add(cmbMeasurementType);
            Controls.Add(lblCategory);
            Controls.Add(lblMeasurementType);
            Controls.Add(txtMeasurement);
            Controls.Add(lblMeasurement);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            Text = "Add Product Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label lblDescription;
        private TextBox txtMeasurement;
        private Label lblMeasurement;
        private Label lblMeasurementType;
        private Label lblCategory;
        private ComboBox cmbMeasurementType;
        private ComboBox cmbCategory;
    }
}