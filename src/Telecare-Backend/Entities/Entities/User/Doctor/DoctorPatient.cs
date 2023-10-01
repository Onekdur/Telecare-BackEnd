using Entities.Models.Members;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorPatient
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Member Member { get; set; }
        public Guid? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
        //public DoctorComment DoctorComment { get; set; }
    }
}
