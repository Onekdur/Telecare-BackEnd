using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorFollower
    {
        [Key]
        public Guid Id { get; set; }
        public Guid FollowerId { get; set; }
        public Guid DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }
}
