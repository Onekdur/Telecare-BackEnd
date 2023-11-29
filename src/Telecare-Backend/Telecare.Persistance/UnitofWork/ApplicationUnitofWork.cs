using Microsoft.EntityFrameworkCore;
using Telecare.Application.Contract;
using Telecare.Domain.Repositories.UserRepository;
using Telecare.Domain.UnitofWork;

namespace Telecare.Persistance.UnitofWork
{
    public class ApplicationUnitofWork : UnitOfWork, IApplicationUnitofWork
    {
        public IMemberRepositrory MemberRepositrory { get; }

        public ApplicationUnitofWork(IApplicationDbContext dbContext, IMemberRepositrory memberRepositrory) :
            base((DbContext)dbContext)
        {
            MemberRepositrory = memberRepositrory;
        }
    }
}
