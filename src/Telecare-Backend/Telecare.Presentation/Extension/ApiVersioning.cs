using Microsoft.Extensions.DependencyInjection;

namespace Telecare.Presentation.Extension
{
    public static class ApiVersioning
    {
        public static void ConfigureAPIVersion(this IServiceCollection services)
        {
            services.AddApiVersioning(option =>
            {
                option.ReportApiVersions = true; //Add an api version to response header
                option.AssumeDefaultVersionWhenUnspecified = true; // specify the default api version if client doesn't specify
                option.DefaultApiVersion = new Asp.Versioning.ApiVersion(1, 0); //set the default version count
            });
        }
    }
}
