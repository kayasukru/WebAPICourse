using Contracts;
using NLog;
using ProjectManagement.Extensions;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(String.Concat(Directory.GetCurrentDirectory(), "/NLog.config"));

// Add services to the container.

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Cors konfig�rasyona ekleniyor
builder.Services.ConfigureCors(); // ServicesExtensions i�inde yazd���m�z metod

builder.Services.ConfigureLoggerManager();

builder.Services.ConfigureSqlContext(builder.Configuration);

builder.Services.ConfigureRepositoryManager();

builder.Services.ConfigureServiceManager();

builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
})
    .AddXmlDataContractSerializerFormatters() // xml format�nda da ��kt� sa�lar
    .AddApplicationPart(typeof(ProjectManagement.Presentation.AssemplyReference).Assembly);




var app = builder.Build();


var logger = app.Services.GetRequiredService<ILoggerManager>();
app.ConfigureExceptionHandler(logger);

if (app.Environment.IsProduction())
{
    app.UseHsts();

}

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
