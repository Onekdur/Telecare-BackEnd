using Telecare.Application.Contract;
using Telecare.Application.Logger;
using Telecare.Domain.Logger;
using Telecare.Persistance.Contexts;

namespace Telecare_Backend.Extension_Method
{
    public static class ServiceExtension
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILogggerManager, LoggerManager>();
            services.AddSingleton<IApplicationDbContext, ApplicationDbContext>();
        }
    }
}
