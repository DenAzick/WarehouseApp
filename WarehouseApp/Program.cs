using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WarehouseApp.Context;
using WarehouseApp.Interfaces;
using WarehouseApp.Repositories;
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
                options.UseNpgsql("Host=localhost;Database=warehouseDb;Username=postgres;Password=denazick"));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddTransient<MainForm>();
            services.AddTransient<SignInForm>();
            services.AddTransient<SignUpForm>();
            services.AddTransient<SettingsForm>();
            services.AddTransient<AddProductForm>();
            services.AddTransient<EditProductForm>();

            services.AddSingleton(new MapperConfiguration(mapper =>
            {
                mapper.AddProfile<AutoMapperService>();
            }).CreateMapper());

            var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetRequiredService<SignInForm>();


            Application.Run(form);
        }
    }
}