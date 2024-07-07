using Microsoft.AspNetCore.Cors.Infrastructure;
using ProjectManagement.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors konfig�rasyona ekleniyor
builder.Services.ConfigureCors(); // ServicesExtensions i�inde yazd���m�z metod

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

//Cors kullanaca��m�z� bildiriyoruz
app.UseCors("CorsPolicy");

app.Run();
