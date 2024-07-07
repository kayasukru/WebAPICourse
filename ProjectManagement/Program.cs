using Microsoft.AspNetCore.Cors.Infrastructure;
using ProjectManagement.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors konfigürasyona ekleniyor
builder.Services.ConfigureCors(); // ServicesExtensions içinde yazdýðýmýz metod

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

//Cors kullanacaðýmýzý bildiriyoruz
app.UseCors("CorsPolicy");

app.Run();
