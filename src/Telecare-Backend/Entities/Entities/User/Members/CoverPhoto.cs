using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Members
{
    public class CoverPhoto
    {
        public Guid Id { get; set; }
        public string CoverPhotoLink { get; set; }
        public bool Ispresent { get; set; } = false;
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
