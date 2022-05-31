using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Reflection;
using VentaDeVehiculo.Data;
using VentaDeVehiculo.UOWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQL"));
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSwaggerGen(document =>
{
    document.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Ejemplo de Api de Automoviles",
            Description = "Prueba de Autos",
            Version = "v1",
            Contact = new OpenApiContact{
                Name="Ejemplo",
                Email="dm@gmail.com",
                Url = new Uri("https://google.com.ar"),
            },
            License = new OpenApiLicense
            {
                Name = "",
                Url = new Uri("https://google.com.ar"),
            }
        });
    // document.EnableAnnotations();
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    document.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ejemplo de Api de Automoviles");
        c.DefaultModelsExpandDepth(-1);
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
