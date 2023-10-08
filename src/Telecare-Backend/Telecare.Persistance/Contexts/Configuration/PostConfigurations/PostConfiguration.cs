using Entities.Models.Post;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Enum;

namespace Telecare.Persistance.Contexts.Configuration.PostConfigurations.PhotoConfiguration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(new Post()
            {
                Id = new Guid("0E1C1417-8DC0-4E9E-834D-89A889D2FB82"),
                Text = "Good morning friens",
                Time = DateTime.Now,
                UserId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82"),
                UserType = UserType.General
            },
            new Post()
            {
                Id = Guid.NewGuid(),
                Text = "Good morning friens",
                Time = DateTime.Now,
                UserId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB85"),
                UserType = UserType.Doctor
            });
        }
    }
}
