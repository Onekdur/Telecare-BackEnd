using Entities.Models.Members;
using Telecare.Domain.Enum;

namespace Entities.Models.Post.PostContent.Photo
{
    public class PhotoLike
    {
        public LikeReact React { get; set; }
        public Guid MemmberId { get; set; }
        public Member Member { get; set; }
        public Guid PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
