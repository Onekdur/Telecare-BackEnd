using Entities.Models.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.MemberConfiguration
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasData(new Education()
            {
                Id = Guid.NewGuid(),
                SchoolName = "Islamic University",
                Degree = "Bsc",
                From = DateTime.UtcNow,
                To = DateTime.Now.AddYears(5),
                UserId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82"),
            },
            new Education()
            {
                Id = Guid.NewGuid(),
                SchoolName = "Rajshahi University",
                Degree = "BA",
                From = DateTime.UtcNow,
                To = DateTime.Now.AddYears(5),
                UserId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB85")
            });
        }
    }
}
