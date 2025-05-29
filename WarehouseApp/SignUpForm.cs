using Microsoft.Extensions.DependencyInjection;
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

namespace WarehouseApp
{
    public partial class SignUpForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IServiceProvider _serviceProvider;
        public SignUpForm(IUserRepository userRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _serviceProvider = serviceProvider;
        }
       

        private void linkLlbSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            var signInForm = _serviceProvider.GetRequiredService<SignInForm>();

            signInForm.ShowDialog();
            Close();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var username = textBoxUsername.Text.Trim();
            var email = textBoxEmail.Text.Trim();
            var pass = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var registrationDto = new RegistrationDto
            {
                Username = username,
                Password = pass,
                Email = string.IsNullOrWhiteSpace(email) ? null : email
            };

            try
            {
                var success = await _userRepository.CreateUserAsync(registrationDto);

                if (success)
                {
                    MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();

                    var mainForm = _serviceProvider.GetRequiredService<MainForm>();

                    mainForm.ShowDialog();

                    Close(); 
                }
                else
                {
                    MessageBox.Show("Пользователь с таким именем уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                var errorMessage = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show($"Ошибка при регистрации:\n{errorMessage}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
