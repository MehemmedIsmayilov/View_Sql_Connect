using Connect_Data_Task.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Connect_Data_Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=MAQA;Database=HomePageDb;Trusted_Connection=True");
            });

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}