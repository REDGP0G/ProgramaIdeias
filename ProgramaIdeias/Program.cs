using Microsoft.EntityFrameworkCore;
using ProgramaIdeias.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Contexto>
//(options => options.UseSqlServer("Data Source=DESKTOP-C1INDDO\\SQLGUILHERME;Initial Catalog=Schwarz;Integrated Security=false;User ID=sa;Password=Lathixp1;Encrypt=False;TrustServerCertificate=False"));
(options => options.UseSqlServer("Data Source=DESKTOP-KKBI7EQ\\SQLEXPRESS;Initial Catalog=Schwarz;Integrated Security=false;User ID=sa;Password=Lathixp1;Encrypt=False;TrustServerCertificate=False"));

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
    pattern: "{controller=Ideia}/{action=Create}/{id?}");

app.Run();
