﻿using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;
using Telecare.Persistance.Contexts;
using Telecare.Presentation.Extension;
using Telecare_Backend.Extension_Method;

var builder = WebApplication.CreateBuilder(args);

//Register Services
builder.Services.SwaggerConfiguration();

//Conncation String
var connectionString = builder.Configuration.GetConnectionString("TelecareDb");
var LoggingconnectionString = builder.Configuration.GetConnectionString("TelecareLoggingDb");

//Serilog Configuration
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .ReadFrom.Configuration(builder.Configuration)
    .CreateBootstrapLogger();

//Service Extension
builder.Services.DependecyServiceConfiguration();

//MediatR  and Fluent Validation Configuration
builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.Load("Telecare.Application")));
builder.Services.AddValidatorsFromAssembly(typeof(Telecare.Application.ApplicationAssemblyReference).Assembly);

//Dbcontext Configuration
builder.Services.AddDbContext<ApplicationDbContext>(option =>
{
    option.UseSqlServer(connectionString, m => m.MigrationsAssembly("Telecare.Api"));
});

// Add Controller project to the services
builder.Services.AddControllers().
    AddApplicationPart(typeof(Telecare.Presentation.PresentationAssemblyReference).Assembly);

//Configure Api versioning.
builder.Services.ConfigureAPIVersion();

try
{
    Log.Write(Serilog.Events.LogEventLevel.Information, "Apllication start");

    var app = builder.Build();

    //Swagger UI Configuraton
    var env = app.Environment;
    app.ConfigureSwaggerUI(env);

    // Configure the HTTP request pipeline.

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Write(Serilog.Events.LogEventLevel.Fatal, $"Apllication can't start because {ex.Message} ");
}
