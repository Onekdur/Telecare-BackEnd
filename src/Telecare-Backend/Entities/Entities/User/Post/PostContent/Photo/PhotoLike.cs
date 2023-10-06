using Entities.Models.Members;
using Telecare.Domain.Entities.Enum;

namespace Entities.Models.Post.PostContent.Photo
{
    public class PhotoLike
    {
        public Guid Id { get; set; }
        public LikeReact React { get; set; }
        public Guid MemmberId { get; set; }
        public Member Member { get; set; }
        public Guid PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
