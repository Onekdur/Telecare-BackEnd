﻿using Telecare.Domain.Enum;

namespace Entities.Models.Post.PostContent.Video
{
    public class VideoLike
    {
        public Guid Id { get; set; }
        public LikeReact React { get; set; }
    }
}
