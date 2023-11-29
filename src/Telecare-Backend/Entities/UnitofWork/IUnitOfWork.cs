using Telecare.Domain.Repositories.UserRepository;

namespace Telecare.Domain.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> SavChangeAsync(CancellationToken cancellationToken);
    }
}
