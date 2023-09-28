using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Member
{
    public class ProfilePhoto
    {
        public Guid Id { get; set; }
        public string? profilePhotoLink { get; set; }
        public bool IsPresent { get; set; } = false;
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }

    }
}
