using Microsoft.EntityFrameworkCore;
using WebApplication4.DAL;

namespace WebApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
             opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            var app = builder.Build();


            app.UseStaticFiles();
            app.MapControllerRoute(
                name:"Default",

                pattern:"{controller}/{action}/{id?}"
                
                );

            app.Run();
        }
    }
}