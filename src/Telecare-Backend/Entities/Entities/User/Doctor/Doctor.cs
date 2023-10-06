using Entities.Models.Members;
using System.ComponentModel.DataAnnotations;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class Doctor
    {
        [Key]
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Experties { get; set; }
        public string Description { get; set; }
        public string PhotoLink { get; set; }
        public double Rating { get; set; }
        public bool IsDeactivate { get; set; } = false;
        public bool IsBlock { get; set; } = false;
        public bool isActive { get; set; } = false;
        public DoctorProfile DoctorProfile { get; set; }
        public List<DoctorPatient> DoctorPatients { get; set; }
        public List<DoctorFollower> DoctorFollowers { get; set; }
        public List<Work> Works { get; set; }
        public List<Education> Educations { get; set; }
        public List<DoctorComment> DoctorComments { get; set; }
        public List<DoctorPatientComplain> DoctorPatientComplains { get; set; }
    }
}
