using Entities.Models;

namespace Telecare.Domain.Entities.Admin
{
    public class BlockMember
    {
        public Guid Id { get; set; }
        public bool Block { get; set; }
        public string Message { get; set; }
    }
}
