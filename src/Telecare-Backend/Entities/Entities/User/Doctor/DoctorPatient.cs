using Entities.Models.Members;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorPatient
    {
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
