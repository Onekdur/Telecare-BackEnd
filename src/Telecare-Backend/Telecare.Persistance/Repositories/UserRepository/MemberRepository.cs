using Entities.Models.Members;
using Telecare.Application.Contract;
using Telecare.Domain.Repositories.UserRepository;

namespace Telecare.Persistance.Repositories.UserRepository
{
    public class MemberRepository : Repository<Member,Guid>, IMemberRepositrory
    {
        public MemberRepository(IApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
