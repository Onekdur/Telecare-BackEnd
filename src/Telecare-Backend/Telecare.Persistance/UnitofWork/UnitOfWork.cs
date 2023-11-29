using Microsoft.EntityFrameworkCore;
using Telecare.Domain.UnitofWork;

namespace Telecare.Persistance.UnitofWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext DbContext { get; }

        public UnitOfWork(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<bool> SavChangeAsync(CancellationToken cancellationToken)
        {
            var result = await DbContext.SaveChangesAsync(cancellationToken);

            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
