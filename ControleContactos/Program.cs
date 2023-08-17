using ControleContactos.Data;
using ControleContactos.Repositorio;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<BancoContext>();

//MSSQL SB Conn:
string connString = builder.Configuration.GetConnectionString("connSQL");
builder.Services.AddDbContext<BancoContext>(o=>o.UseSqlServer(connString));
builder.Services.AddScoped<IContactoRepositorio, ContactoRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
