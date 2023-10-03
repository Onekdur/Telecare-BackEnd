using Entities.Models.Members;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorFollower
    {
        public Guid Id { get; set; }
        public Guid FollowerId { get; set; }
        public Member Member { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
