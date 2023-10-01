using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorPatientConfiguration : IEntityTypeConfiguration<DoctorPatient>
    {
        public void Configure(EntityTypeBuilder<DoctorPatient> builder)
        {

            builder.HasData(new DoctorPatient()
            {
                Id = Guid.NewGuid(),
                PatientId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82"),
                DoctorId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB85")
            });
        }
    }
}
