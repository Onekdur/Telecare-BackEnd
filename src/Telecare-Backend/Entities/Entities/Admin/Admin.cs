using Entities.Models.Members;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telecare.Domain.Entities.Admins
{
    public class Admin
    {
        public Guid Id { get; set; }
        public bool CEO { get; set; } = false;
        public bool SuperAdmin { get; set; } = false;
        public bool GeneralAdmin { get; set; } = false;
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
