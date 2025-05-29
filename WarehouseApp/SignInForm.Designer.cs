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
            textBoxPassword = new TextBox();
            linkLblSignUp = new LinkLabel();
            lblSignIn = new Label();
            textBoxUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(274, 220);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(250, 23);
            textBoxPassword.TabIndex = 17;
            textBoxPassword.Text = "password";
            // 
            // linkLblSignUp
            // 
            linkLblSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLblSignUp.Location = new Point(11, 353);
            linkLblSignUp.Name = "linkLblSignUp";
            linkLblSignUp.Size = new Size(762, 21);
            linkLblSignUp.TabIndex = 16;
            linkLblSignUp.TabStop = true;
            linkLblSignUp.Text = "Sign up?";
            linkLblSignUp.TextAlign = ContentAlignment.TopCenter;
            linkLblSignUp.LinkClicked += linkLblSignUp_LinkClicked;
            // 
            // lblSignIn
            // 
            lblSignIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSignIn.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblSignIn.Location = new Point(11, 74);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(778, 52);
            lblSignIn.TabIndex = 14;
            lblSignIn.Text = "Sign in";
            lblSignIn.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(274, 191);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(247, 23);
            textBoxUsername.TabIndex = 13;
            textBoxUsername.Text = "username";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(274, 249);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(250, 23);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(textBoxPassword);
            Controls.Add(linkLblSignUp);
            Controls.Add(lblSignIn);
            Controls.Add(textBoxUsername);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private LinkLabel linkLblSignUp;
        private Label lblSignIn;
        private TextBox textBoxUsername;
        private Button btnLogin;
    }
}