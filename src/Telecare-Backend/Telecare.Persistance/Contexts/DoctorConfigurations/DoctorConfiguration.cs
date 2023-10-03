using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasData(new Doctor()
            {
                Id = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB85"),
                FullName = "Dr Md Sagore",
                Description = "I am pathologist",
                Experties = "Surgery",
                PhotoLink = "www.aws.com",
                Rating = 4.6,
            });
        }
    }
}
