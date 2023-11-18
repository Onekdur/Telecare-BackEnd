using Telecare.Application.Contract;
using Telecare.Application.Logger;
using Telecare.Domain.Logger;
using Telecare.Domain.Repositories.UserRepository;
using Telecare.Domain.UnitofWork;
using Telecare.Persistance.Contexts;
using Telecare.Persistance.Repositories.UserRepository;
using Telecare.Persistance.UnitofWork;

namespace Telecare_Backend.Extension_Method
{
    public static class DependencyService
    {
        public static void DependecyServiceConfiguration(this IServiceCollection services)
        {
            //Logger 
            services.AddSingleton<ILogggerManager, LoggerManager>();
            //DBContext
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            //unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //repository
            services.AddScoped<IMemberRepositrory, MemberRepository>();
        }
    }
}
