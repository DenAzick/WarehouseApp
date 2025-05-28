using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WarehouseApp.Context;
using WarehouseApp.Services;

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

            services.AddSingleton(new MapperConfiguration(mapper =>
            {
                mapper.AddProfile<AutoMapperService>();
            }).CreateMapper());

            var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetRequiredService<MainForm>();


            Application.Run(form);
        }
    }
}