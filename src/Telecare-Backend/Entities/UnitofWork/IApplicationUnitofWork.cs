using Telecare.Domain.Repositories.UserRepository;

namespace Telecare.Domain.UnitofWork
{
    public interface IApplicationUnitofWork : IUnitOfWork
    {
        IMemberRepositrory MemberRepositrory { get; }
    }
}
