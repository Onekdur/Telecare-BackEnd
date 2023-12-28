using System.Linq.Expressions;
using Telecare.Domain.Common;

namespace Telecare.Domain.Repositories
{
    public interface IRepository<TEntity,Tkey> where TEntity : class, IEntity<Tkey>
    {
        Task IsertAsync(TEntity entity, CancellationToken cancellationToken = default);

        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);

        Task<IQueryable<TEntity>> GetSingleAsync(Expression<Func<TEntity, bool>> expression,
            bool trackChnage, CancellationToken cancellationToken = default);

        Task<IQueryable<TEntity>> GetAllAsync(bool trackChange, CancellationToken cancellationToken = default);

        Task<bool> IsExistAsync(Guid id, CancellationToken cancellationToken = default);

        Task<int> GetCountAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
