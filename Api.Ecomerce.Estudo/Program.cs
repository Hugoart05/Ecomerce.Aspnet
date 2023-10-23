using DAL.Context;
using DAL.Interfaces;
using DAL.Repositories;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Services.Services.Usuario;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
string? connString = builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add dependency injection Repositories 
builder.Services.AddScoped<IRepositoryBase<Usuario>, IUsuario>();
builder.Services.AddScoped<IRepositoryBase<Produto>, IProduto>();
builder.Services.AddScoped<IRepositoryBase<ItemDeCarrinho>, IItemCarrinho>();
builder.Services.AddScoped<IRepositoryBase<Carrinho>, ICarrinho>();


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
