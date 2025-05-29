namespace WarehouseApp
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            linkLlbSignIn = new LinkLabel();
            textBoxPassword = new TextBox();
            RegisterLabel = new Label();
            textBoxUsername = new TextBox();
            btnRegister = new Button();
            textBoxEmail = new TextBox();
            SuspendLayout();
            // 
            // linkLlbSignIn
            // 
            linkLlbSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLlbSignIn.Location = new Point(2, 317);
            linkLlbSignIn.Name = "linkLlbSignIn";
            linkLlbSignIn.Size = new Size(778, 23);
            linkLlbSignIn.TabIndex = 10;
            linkLlbSignIn.TabStop = true;
            linkLlbSignIn.Text = "Sign in?";
            linkLlbSignIn.TextAlign = ContentAlignment.TopCenter;
            linkLlbSignIn.LinkClicked += linkLlbSignIn_LinkClicked;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(265, 213);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 23);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.Text = "password";
            // 
            // RegisterLabel
            // 
            RegisterLabel.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegisterLabel.Location = new Point(2, 38);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(778, 52);
            RegisterLabel.TabIndex = 8;
            RegisterLabel.Text = "Sign up";
            RegisterLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(265, 155);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(250, 23);
            textBoxUsername.TabIndex = 7;
            textBoxUsername.Text = "username";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRegister.Location = new Point(265, 271);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(250, 23);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.Location = new Point(265, 184);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 23);
            textBoxEmail.TabIndex = 11;
            textBoxEmail.Text = "email";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(textBoxEmail);
            Controls.Add(linkLlbSignIn);
            Controls.Add(textBoxPassword);
            Controls.Add(RegisterLabel);
            Controls.Add(textBoxUsername);
            Controls.Add(btnRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLlbSignIn;
        private TextBox textBoxPassword;
        private Label RegisterLabel;
        private TextBox textBoxUsername;
        private Button btnRegister;
        private TextBox textBoxEmail;
    }
}