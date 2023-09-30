using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Members
{
    public class Education
    {
        [Key]
        public Guid Id { get; set; }
        public string? SchoolName { get; set; }
        public string? Degree { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool CureentlyRunnig { get; set; } = false;
        public string? Description { get; set; }
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
