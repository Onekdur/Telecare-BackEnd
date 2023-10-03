using Entities.Models.Members;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorProfile
    {
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
        public Guid DoctorID { get; set; }
        public Doctor Doctor { get; set; }
    }
}
