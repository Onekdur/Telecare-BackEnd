using Entities.Models.Post.PostContent.Photo;

namespace Entities.Models.Post
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        List<Photo> Photos { get; set; }
    }
}
