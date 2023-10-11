using Telecare.Application.Logger;
using Telecare.Domain.Logger;

namespace Telecare_Backend.Extension_Method
{
    public static class ServiceExtension
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILogggerManager, LoggerManager>();
        }
    }
}
