using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Users;

namespace WarehouseApp;

public partial class SignInForm : Form
{
    private readonly IUserRepository _userRepository;
    private readonly IServiceProvider _serviceProvider;

    public SignInForm(IUserRepository userRepository, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _userRepository = userRepository;
        _serviceProvider = serviceProvider;
    }

    private void linkLblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Hide();
        var signUpForm = _serviceProvider.GetRequiredService<SignUpForm>();
        signUpForm.ShowDialog();
        Close();
    }

    private async void btnLogin_Click(object sender, EventArgs e)
    {
        var username = textBoxUsername.Text.Trim();
        var pass = textBoxPassword.Text.Trim();

        if (string.IsNullOrWhiteSpace(textBoxUsername.Text) || string.IsNullOrWhiteSpace(textBoxPassword.Text))
        {
            MessageBox.Show("Please fill in all required fields.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var loginDto = new LoginDto
        {
            Username = username,
            Password = pass
        };

        bool result = await _userRepository.LoginUserAsync(loginDto);

        try
        {
            bool isAuthenticated = await _userRepository.LoginUserAsync(loginDto);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();

                var mainForm = _serviceProvider.GetRequiredService<MainForm>();
                mainForm.ShowDialog();

                Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error during login: {ex.Message}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
