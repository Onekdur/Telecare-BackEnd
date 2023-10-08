using Entities.Models.Post.PostContent.Photo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Enum;

namespace Telecare.Persistance.Contexts.Configuration.PostConfigurations.PhotoConfiguration
{
    public class PhotoCommnetLikeConfiguration : IEntityTypeConfiguration<PhotoCommentLike>
    {
        public void Configure(EntityTypeBuilder<PhotoCommentLike> builder)
        {
            builder.HasKey(e => new { e.MemmberId, e.PhotoCommentId });

            builder.HasOne(e => e.Member)
                .WithMany(e => e.PhotoCommentLikes)
                .HasForeignKey(e => e.MemmberId);

            builder.HasOne(e => e.PhotoComment)
               .WithMany(e => e.PhotoCommentLikes)
               .HasForeignKey(e => e.PhotoCommentId);

            builder.HasData(new PhotoCommentLike()
            {
                LikeReact = LikeReact.Love,
                MemmberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82"),
                PhotoCommentId = new Guid("0E1C1418-8DC1-4E9E-834D-89A889D2FB82")
            });
        }
    }
}
