using Entities.Models.Post.PostContent.Photo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.PostConfigurations.PhotoConfiguration
{
    public class PhotoLikeConfiguration : IEntityTypeConfiguration<PhotoLike>
    {
        public void Configure(EntityTypeBuilder<PhotoLike> builder)
        {
            builder.HasKey(e => new {e.MemmberId, e.PhotoId});

            builder.HasOne(e => e.Member)
                .WithMany(e => e.PhotoLikes)
                .HasForeignKey(e => e.MemmberId);

            builder.HasOne(e => e.Photo)
               .WithMany(e => e.PhotoLikes)
               .HasForeignKey(e => e.PhotoId);

            builder.HasData(new PhotoLike()
            {
                PhotoId = new Guid("0E1C1417-8DC1-4E9E-834D-89A889D2FB82"),
                MemmberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            });
        }
    }
}
