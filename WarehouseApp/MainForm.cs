using WarehouseApp.Context;

namespace WarehouseApp
{
    public partial class MainForm : Form
    {
        private readonly AppDbContext _context;

        public MainForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
