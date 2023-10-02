using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

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
        public bool IsPrivate { get; set; } = false;
        public bool IsDelete { get; set; } = false;
        public Guid UserId { get; set; }
    }
}
