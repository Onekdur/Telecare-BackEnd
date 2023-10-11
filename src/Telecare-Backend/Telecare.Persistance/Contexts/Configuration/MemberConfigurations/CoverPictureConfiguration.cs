using Entities.Models.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.MemberConfiguration
{
    public class CoverPictureConfiguration : IEntityTypeConfiguration<CoverPhoto>
    {
        public void Configure(EntityTypeBuilder<CoverPhoto> builder)
        {
            builder.HasData(new CoverPhoto()
            {
                Id = Guid.NewGuid(),
                CoverPhotoLink = "www.colud.com",
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            },
            new CoverPhoto()
            {
                Id = Guid.NewGuid(),
                CoverPhotoLink = "www.aws.com",
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            }); ;
        }
    }
}
