using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorPatientComplainConfiguration : IEntityTypeConfiguration<DoctorPatientComplain>
    {
        public void Configure(EntityTypeBuilder<DoctorPatientComplain> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Member)
                .WithMany(e => e.DoctorPatientComplains)
                .HasForeignKey(e => e.PatientId);

            builder.HasOne(e => e.Doctor)
                .WithMany(e => e.DoctorPatientComplains)
                .HasForeignKey(e => e.DoctorId);

            builder.HasData(new DoctorPatientComplain()
            {
                Id = Guid.NewGuid(),
                Comment = "Doctor's behave very dangerous ",
                DoctorId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB85"),
                PatientId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            });
        }
    }
}
