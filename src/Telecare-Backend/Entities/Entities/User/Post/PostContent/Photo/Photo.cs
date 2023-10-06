namespace Entities.Models.Post.PostContent.Photo
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string PhotLink { get; set; }
        public List<PhotoLike> PhotoLikes { get; set; }
        public List<PhotoComment> PhotoComments { get; set; }
        public List<PhotoShare> PhotoShares { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }
    }
}
