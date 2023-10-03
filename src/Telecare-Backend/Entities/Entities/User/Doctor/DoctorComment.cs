using Entities.Models.Members;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorComment
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public DateTime Time { get; set; }
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
