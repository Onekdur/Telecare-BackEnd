using Entities.Models.Post.PostContent.Photo;
using Telecare.Domain.Enum;

namespace Entities.Models.Post
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public UserType UserType { get; set; }
        public Guid UserId { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
