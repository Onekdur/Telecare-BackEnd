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

        public async Task<bool> SavChangeAsync(CancellationToken cancellationToken)
        {
           var result = await applicationDbContext.SaveChangesAsync(cancellationToken);
           
           if(result > 0)
           {
              return true;
           }
           return false;
        }

        public void Dispose()
        {
             applicationDbContext.Dispose();
        }
    }
}
