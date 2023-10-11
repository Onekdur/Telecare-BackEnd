using Entities.Models.Members;

namespace Entities.Models.Post.PostContent.Photo
{
    public class PhotoComment
    {
        public Guid Id { get; set; }
        public string Text { get; set; } 
        public DateTime Time { get; set; }
        public Guid MemmberId { get; set; }
        public Member Member { get; set; }
        public Guid PhotoId { get; set; }
        public Photo Photo { get; set; }
        public List<PhotoCommentLike> PhotoCommentLikes { get; set; }
        //public List<PhotoCommentPicture> PhotoCommentPictures { get; set; }
    }
}
