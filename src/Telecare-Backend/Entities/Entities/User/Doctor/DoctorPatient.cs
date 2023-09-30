using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorPatient
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

    }
}
