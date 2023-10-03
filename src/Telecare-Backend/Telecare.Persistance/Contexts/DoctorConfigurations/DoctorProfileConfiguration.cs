using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorProfileConfiguration : IEntityTypeConfiguration<DoctorProfile>
    {
        public void Configure(EntityTypeBuilder<DoctorProfile> builder)
        {
            builder.HasData(new DoctorProfile()
            {
                Id = Guid.NewGuid(),
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82"),
                DoctorID = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB85")
            });
        }
    }
}
