using Microsoft.VisualBasic.ApplicationServices;
using WarehouseApp.Context;
using WarehouseApp.Interfaces;
using WarehouseApp.Models.Users;

namespace WarehouseApp
{
    public partial class MainForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IServiceProvider _serviceProvider;


        public MainForm(AppDbContext context, IUserRepository userRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userRepository = userRepository;
            _serviceProvider = serviceProvider;
        }
       


        private void MainForm_Load(object sender, EventArgs e)
        {
            //lblUsername.Text = $"Имя: {_userDto.Username}";
            //lblRole.Text = $"Роль: {_userDto.Role}";
        }

        

       
    }
}
