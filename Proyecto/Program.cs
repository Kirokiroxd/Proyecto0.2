using Microsoft.EntityFrameworkCore;
using Proyecto.Data;

var builder = WebApplication.CreateBuilder(args);

// MVC CON VISTAS (NO API)
builder.Services.AddControllersWithViews();

// DbContext MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// RUTA MVC POR DEFECTO
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Proyectos}/{action=Index}/{id?}");

app.Run();