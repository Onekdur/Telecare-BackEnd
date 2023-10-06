using Entities.Models.Members;

namespace Entities.Models.Post.PostContent.Photo
{
    public class PhotoCommentPicture
    {
        public Guid Id { get; set; }
        public string CommentPictureLink { get; set; }
        public Guid MemmberId { get; set; }
        public Member Member { get; set; }
        public Guid PhotoCommentId { get; set; }
        public PhotoComment PhotoComment { get; set; }
    }
}
