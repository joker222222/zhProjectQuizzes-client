using System.Reflection;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Models;
using DataAccess.Wrapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


//"Server=DESKTOP-K6LFJKO;Database=Qwiz;User Id=sa;password=12345;Encrypt=True;TrustServerCertificate=True;";
builder.Services.AddDbContext<QwizContext>(
    options => 
    options.UseSqlServer("Server=localhost;Database=Qwiz;User Id=sa;password=12345;Encrypt=True;TrustServerCertificate=True;"));

builder.Services.AddScoped<IRepositoryWrapper,RepositoryWrapper>();
builder.Services.AddScoped<IUserService,UserService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
