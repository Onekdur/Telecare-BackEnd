using Entities.Models.Members;
using System.ComponentModel.DataAnnotations.Schema;

namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorRequest
    {
        public Guid Id { get; set; }
        public string? FullName { get; set; }
        public string? Experties { get; set; }
        public string? HscCertificate { get; set; }
        public string? SSCCertificate { get; set; }
        public string MedicalSChoolCertificate { get; set; }
        public string MedicalIdCard { get; set; }
        public bool Accept { get; set; } = false;
        public bool Pending { get; set; } = true;
        public bool Reject { get; set; } = false;
        public bool isSeen { get; set; } = false;
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
