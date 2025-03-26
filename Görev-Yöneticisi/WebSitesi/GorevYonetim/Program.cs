using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Constract;  // IUserServices burada tanımlıysa


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();


        builder.Services.AddDbContext<RepositoryContext>(options =>
        {
            options.UseSqlite(builder.Configuration.
            GetConnectionString("sqlconnection"), b => b.MigrationsAssembly("GorevYonetim"));
        });

        
        builder.Services.AddScoped<IUserServices,UserService>();

        builder.Services.AddScoped<IUserRepository, UserRepository>();

        var app = builder.Build();
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}