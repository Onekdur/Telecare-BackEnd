using Telecare.Domain.Enum;

namespace Entities.Models.Post
{
    public class Like
    {
        public Guid Id { get; set; }
        public LikeReact React { get; set; }
    }
}
