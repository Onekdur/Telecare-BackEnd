using System.ComponentModel.DataAnnotations;

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
        public bool isPrivate { get; set; }
        public bool isDelete { get; set; }
        public Guid UserId { get; set; }
    }
}
