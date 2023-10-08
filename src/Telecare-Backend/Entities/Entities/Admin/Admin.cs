using Entities.Models.Members;
using Telecare.Domain.Enum;

namespace Telecare.Domain.Entities.Admins
{
    public class Admin
    {
        public Guid Id { get; set; }
        public AdminType AdminType { get; set; }
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
