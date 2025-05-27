using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WarehouseApp.Context;

namespace WarehouseApp
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql("Host=localhost;Database=warehouseDb;Username=postgres;Password=postgres"));

            services.AddTransient<MainForm>();
            services.AddTransient<SignInForm>();

            var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetRequiredService<MainForm>();


            Application.Run(form);
        }
    }
}