using Entities.Models.Members;

namespace Entities.Models.Post.PostContent.Photo
{
    public class PhotoShare
    {
        public Guid Id { get; set; }
        public Guid MemmberId { get; set; }
        public Member Member { get; set; }
        public Guid PhotoId { get; set; }
        public Photo Photo { get; set; }
    }
}
