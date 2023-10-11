using Entities.Models.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.MemberConfiguration
{
    public class ProfilePictureConfiguration : IEntityTypeConfiguration<ProfilePhoto>
    {
        public void Configure(EntityTypeBuilder<ProfilePhoto> builder)
        {
            builder.HasData(new ProfilePhoto()
            {
                Id = Guid.NewGuid(),
                profilePhotoLink = "www.colud.com",
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            },
            new ProfilePhoto()
            {
                Id = Guid.NewGuid(),
                profilePhotoLink = "www.aws.com",
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            }); ;
        }
    }
}
