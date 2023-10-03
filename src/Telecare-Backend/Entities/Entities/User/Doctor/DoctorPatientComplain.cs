using Entities.Models.Members;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorPatientComplain
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public Guid PatientId { get; set; }
        public Member Member { get; set; }
        public Guid? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
