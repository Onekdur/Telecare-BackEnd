using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Member
{
    public class Work
    {
        [Key]
        public Guid WorkId { get; set; }
        public string Title { get; set; }
        public string ComapnyName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool CurrentlyRunning { get; set; } = false;
        public string? Description { get; set; }
        [ForeignKey("MemberID")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
