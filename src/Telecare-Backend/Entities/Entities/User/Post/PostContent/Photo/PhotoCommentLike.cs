using Entities.Models.Members;
using Telecare.Domain.Entities.Enum;

namespace Entities.Models.Post.PostContent.Photo
{
    public class PhotoCommentLike
    {
        public Guid Id { get; set; }
        public LikeReact LikeReact { get; set; }
        public Guid MemmberId { get; set; }
        public Member Member { get; set; }
        public Guid PhotoCommentLikeId { get; set; }
        public PhotoComment PhotoComment { get; set; }
    }
}
