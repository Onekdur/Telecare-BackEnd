using Entities.Models.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration.MemberConfiguration
{
    public class WorkConfiguration : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasData(new Work()
            {
                Id = Guid.NewGuid(),
                ComapnyName = "Devskill",
                Title = "Intern Software Enginer",
                From = DateTime.Now,
                To = DateTime.Now.AddHours(20),
                Description = "Hi this sojib",
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            },
            new Work()
            {
                Id = Guid.NewGuid(),
                ComapnyName = "Vivasoft",
                Title = " Software Enginer",
                From = DateTime.Now,
                To = DateTime.Now.AddHours(30),
                Description = "Descriptiom",
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            }) ;
        }
    }
}
