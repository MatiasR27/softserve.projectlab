using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using API.Controllers;
using API.Services;
using API.implementations.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configurar Entity Framework con SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Agregar servicios para controllers
builder.Services.AddControllers();

// Agregar Swagger
builder.Services.AddSwaggerGen();  // Este es el servicio que habilita Swagger en tu API

// Agregar el servicio ProductService
builder.Services.AddScoped<ProductService>();

var app = builder.Build();

// Habilitar el uso de Swagger en la API
if (app.Environment.IsDevelopment())  // Solo habilitar Swagger en desarrollo
{
    app.UseSwagger();  // Habilita el middleware Swagger
    app.UseSwaggerUI();  // Habilita la UI de Swagger
}


// Configurar los controladores
app.MapControllers();

app.Run();
