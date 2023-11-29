using Microsoft.EntityFrameworkCore;
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
            services.AddScoped<DbContext>();

            //unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IApplicationUnitofWork,ApplicationUnitofWork>();

            //repository
            services.AddScoped<IMemberRepositrory, MemberRepository>();
        }
    }
}
