using Telecare.Application.Contract;
using Telecare.Domain.UnitofWork;

namespace Telecare.Persistance.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IApplicationDbContext applicationDbContext;

        public UnitOfWork(IApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
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
