namespace WarehouseApp
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            button1 = new Button();
            textBox1 = new TextBox();
            loginLabel = new Label();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(275, 268);
            button1.Name = "button1";
            button1.Size = new Size(247, 23);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(275, 189);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "username";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += this.textBox1_TextChanged;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            loginLabel.Location = new Point(4, 35);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(778, 52);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Sign in";
            loginLabel.TextAlign = ContentAlignment.TopCenter;
            loginLabel.Click += this.loginLabel_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(275, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "password";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += this.textBox2_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.Location = new Point(12, 314);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(778, 23);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up?";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
            // 
            // SignInForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(784, 561);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(loginLabel);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignInForm";
            Text = "SignInForm";
            Load += SignInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label loginLabel;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
    }
}