using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Telecare.Application.Contract;
using Telecare.Domain.Common;
using Telecare.Domain.Repositories;

namespace Telecare.Persistance.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IApplicationDbContext dbContext;
        private DbSet<TEntity> dbSet;

        protected Repository(IApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
            dbSet = dbContext.Dbset<TEntity>();
        }
        public async Task IsertAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
           await dbSet.AddAsync(entity,cancellationToken);
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
           await Task.Run(() => dbSet.Remove(entity),cancellationToken);
        }

        public async Task<IQueryable<TEntity>> GetAllAsync(bool trackChange, 
            CancellationToken cancellationToken = default) 
        {
            return  (IQueryable<TEntity>) ( !trackChange ? dbSet.AsNoTracking().ToListAsync(cancellationToken) 
                : dbSet.ToListAsync(cancellationToken));
        }  
        
        public async Task<IQueryable<TEntity>> GetSingleAsync(Expression<Func<TEntity, bool>> expression, 
            bool trackChange, CancellationToken cancellationToken = default)
        {
           return (IQueryable<TEntity>) (!trackChange ? dbSet.Where(expression).AsNoTracking().ToListAsync(cancellationToken) 
                : dbSet.Where(expression).ToListAsync(cancellationToken)); 
        }

        public Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
           
        public Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
