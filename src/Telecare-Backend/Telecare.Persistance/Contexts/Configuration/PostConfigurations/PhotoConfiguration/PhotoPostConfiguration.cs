using Entities.Models.Post.PostContent.Photo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.PostConfigurations.PhotoConfiguration
{
    public class PhotoPostConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Post)
                .WithMany(e => e.Photos)
                .HasForeignKey(e => e.PostId);

            builder.HasData(new Photo()
            {
                Id = new Guid("0E1C1417-8DC1-4E9E-834D-89A889D2FB82"),
                PhotLink = "www.aws.com",
                PostId = new Guid("0E1C1417-8DC0-4E9E-834D-89A889D2FB82")
            });
        }
    }
}
