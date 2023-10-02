using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorComment
    {
        [Key]
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public Guid PatientId { get; set; }
        public Guid? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }
}
