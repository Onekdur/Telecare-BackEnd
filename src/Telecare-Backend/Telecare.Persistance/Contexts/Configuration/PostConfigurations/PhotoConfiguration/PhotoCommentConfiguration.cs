using Entities.Models.Post.PostContent.Photo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.PostConfigurations.PhotoConfiguration
{
    public class PhotoCommentConfiguration : IEntityTypeConfiguration<PhotoComment>
    {
        public void Configure(EntityTypeBuilder<PhotoComment> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Member)
                .WithMany(e => e.PhotoComments)
                .HasForeignKey(e => e.MemmberId);

            builder.HasOne(e => e.Photo)
               .WithMany(e => e.PhotoComments)
               .HasForeignKey(e => e.PhotoId);

            builder.HasData(new PhotoComment()
            {
                Id = Guid.NewGuid(),
                Text = "Very Nice",
                Time = DateTime.Now,
                PhotoId = new Guid("0E1C1417-8DC1-4E9E-834D-89A889D2FB82"),
                MemmberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            });
        }
    }
}
