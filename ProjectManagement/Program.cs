using NLog;
using ProjectManagement.Extensions;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/NLog.config"));

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors konfigürasyona ekleniyor
builder.Services.ConfigureCors(); // ServicesExtensions içinde yazdığımız metod

builder.Services.ConfigureLoggerManager();

builder.Services.ConfigureSqlContext(builder.Configuration);

builder.Services.ConfigureRepositoryManager();

builder.Services.ConfigureServiceManager();



builder.Services.AddControllers()
    .AddApplicationPart(typeof(ProjectManagement.Presentation.AssemplyReference).Assembly);




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

//Cors kullanacağımızı bildiriyoruz
app.UseCors("CorsPolicy");

app.Run();
