using Telecare.Domain.Repositories.UserRepository;

namespace Telecare.Domain.UnitofWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task SavChangeAsync(CancellationToken cancellationToken);
        IMemberRepositrory MemberRepositrory { get;}
    }
}
