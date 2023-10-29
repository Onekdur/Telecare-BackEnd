using Telecare.Domain.Repositories.UserRepository;
using Telecare.Domain.UnitofWork;
using Telecare.Persistance.Repositories.UserRepository;
using Telecare.Persistance.UnitofWork;

namespace Telecare_Backend.Extension_Method
{
    public static class DependencyService
    {
        public static void DependecyServiceConfiguration(this IServiceCollection services)
        {
            //unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            //repository
            services.AddScoped<IMemberRepositrory, MemberRepository>();
        }
    }
}
