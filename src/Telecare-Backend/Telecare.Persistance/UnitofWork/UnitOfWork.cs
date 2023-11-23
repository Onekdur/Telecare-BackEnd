using Telecare.Application.Contract;
using Telecare.Domain.Repositories.UserRepository;
using Telecare.Domain.UnitofWork;

namespace Telecare.Persistance.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext applicationDbContext;
        public IMemberRepositrory MemberRepositrory { get;}
        public UnitOfWork(IApplicationDbContext applicationDbContext, 
            IMemberRepositrory memberRepositrory)
        {
            this.applicationDbContext = applicationDbContext;
            MemberRepositrory = memberRepositrory;
        }

        public async Task SavChangeAsync(CancellationToken cancellationToken)
        {
            await applicationDbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
             applicationDbContext.Dispose();
        }
    }
}
