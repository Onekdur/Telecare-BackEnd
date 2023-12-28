using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Serilog;
using SigalIRHub.Hub;
using Telecare.Application.Logger;
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

//

//MediatR  and Fluent Validation Configuration
var assembly = typeof(Telecare.Application.ApplicationAssemblyReference).Assembly; //Get Assembly for this Telecare.Application Project.

builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(assembly));
builder.Services.AddValidatorsFromAssembly(assembly);

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

//SignalIR Configuration
builder.Services.AddSignalR();

try
{
    Log.Write(Serilog.Events.LogEventLevel.Information, "Apllication start");

    var app = builder.Build();

    //Swagger UI Configuraton
    var env = app.Environment;
    app.ConfigureSwaggerUI(env);

    /*Configure the HTTP request pipeline.*/

    //Congfigure global error handling using mildleware
    app.ConfigureExceptionHandler(new LoggerManager());


    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    //SignIr Middleware Configuration
    app.MapHub<ChatHub>("/chat");

    app.Run();
}
catch (Exception ex)
{
    Log.Write(Serilog.Events.LogEventLevel.Fatal, $"Apllication can't start because {ex.Message} ");
}
