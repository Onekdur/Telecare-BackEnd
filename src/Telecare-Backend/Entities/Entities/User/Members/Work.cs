using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Telecare.Domain.Entities.User.Doctor;

namespace Entities.Models.Members
{
    public class Work
    {
        [Key]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? ComapnyName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool CurrentlyRunning { get; set; } = false;
        public string Description { get; set; }
        public Guid MemberId { get; set; }
        //[ForeignKey("MemberId")]
        //[DeleteBehavior(DeleteBehavior.Cascade)]
        public Member Member { get; set; }
        public Guid? DoctorId { get; set; }
        //[ForeignKey("DoctorId")]
        //[DeleteBehavior(DeleteBehavior.Cascade)]
        public Doctor Doctor { get; set; }
    }
}
