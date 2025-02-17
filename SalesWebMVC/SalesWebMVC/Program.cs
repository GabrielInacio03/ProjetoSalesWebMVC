using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalesWebMVC.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("DataContext"),
        new MySqlServerVersion(new Version(8, 0, 25)), // Substitua pela versão do seu servidor MySQL
        mysqlOptions => mysqlOptions.MigrationsAssembly("SalesWebMVC")));



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
