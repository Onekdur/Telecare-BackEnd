namespace Entities.Models.Post.PostContent.Photo
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string PhotLink { get; set; }
        List<PhotoLike> PhotoLikes { get; set; }
    }
}
