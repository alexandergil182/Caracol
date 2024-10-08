using CaracolTanqueos.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TanqueosContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=MenuPrincipal}/{action=Index}");


app.Run();
