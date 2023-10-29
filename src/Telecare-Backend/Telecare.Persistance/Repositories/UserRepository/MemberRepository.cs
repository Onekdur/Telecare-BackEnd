using Entities.Models.Members;
using Telecare.Application.Contract;
using Telecare.Domain.Repositories.UserRepository;

namespace Telecare.Persistance.Repositories.UserRepository
{
    public class MemberRepository : Repository<Member>, IMemberRepositrory
    {
        protected MemberRepository(IApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
