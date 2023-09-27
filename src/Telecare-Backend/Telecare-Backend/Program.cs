using Microsoft.EntityFrameworkCore;
using Telecare.Persistance.Contexts;
using Telecare_Backend.Extension_Method;

var builder = WebApplication.CreateBuilder(args);

//Register Services

builder.Services.SwaggerConfiguration();

//Dbcontext Configuration

builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("TelecareDb"), 
        m => m.MigrationsAssembly("Telecare.Api"));
});

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

//Swagger UI Configuraton

var env = app.Environment;
app.ConfigureSwaggerUI(env);

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
