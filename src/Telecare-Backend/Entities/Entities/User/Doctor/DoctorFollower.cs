using Entities.Models.Members;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorFollower
    {
        [Key]
        public Guid Id { get; set; }
        public Guid FollowerId { get; set; }
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
