using Entities.Models.Members;
using Telecare.Domain.Entities.Enum;

namespace Entities.Models.Post.PostContent.Photo
{
    public class PhotoCommentLike
    {
        public LikeReact LikeReact { get; set; }
        public Guid MemmberId { get; set; }
        public Member Member { get; set; }
        public Guid PhotoCommentId { get; set; } 
        public PhotoComment PhotoComment { get; set; }
    }
}
