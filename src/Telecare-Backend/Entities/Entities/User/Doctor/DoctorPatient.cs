namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorPatient
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
    }
}
