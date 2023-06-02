using TesteSebrae.Application.Services;
using TesteSebrae.Domain.Repositories;
using TesteSebrae.Infra.Repositories;
using TesteSebrae.Application.AutoMapper;
using TesteSebrae.Application.Interfaces;
using Microsoft.Extensions.Configuration;
using TesteSebrae.Infra.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddScoped<ICEPService, CEPService>();
builder.Services.AddScoped<IContaService, ContaService>();
builder.Services.AddScoped<IContaRepository, ContaRepository>();
builder.Services.AddScoped<ICEPRepository, CEPRepository>();

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("WebApiDatabase")
    ));

builder.Services.AddAutoMapper(typeof(AutoMapperSetup));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
