using Microsoft.EntityFrameworkCore;
using TesteSebrae.Application.AutoMapper;
using TesteSebrae.Application.Interfaces;
using TesteSebrae.Application.Services;
using TesteSebrae.Domain.Repositories;
using TesteSebrae.Infra.Data;
using TesteSebrae.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ICEPService, CEPService>();
builder.Services.AddScoped<IContaService, ContaService>();
builder.Services.AddScoped<IContaRepository, ContaRepository>();
builder.Services.AddScoped<ICEPRepository, CEPRepository>();

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("WebApiDatabase")
    ));

builder.Services.AddAutoMapper(typeof(AutoMapperSetup));

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
