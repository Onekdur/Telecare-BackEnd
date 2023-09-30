using System.ComponentModel.DataAnnotations.Schema;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorComment
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        [ForeignKey("DoctorId")]
        public  Doctor Doctor { get; set; }
        [ForeignKey("PatientId")]
        public DoctorPatient Patient { get; set; }
    }
}
