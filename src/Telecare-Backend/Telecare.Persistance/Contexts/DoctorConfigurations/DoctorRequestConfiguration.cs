using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorRequestConfiguration : IEntityTypeConfiguration<DoctorRequest>
    {
        public void Configure(EntityTypeBuilder<DoctorRequest> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(new DoctorRequest()
            {
                Id = Guid.NewGuid(),
                FullName = "Dr Md Sojib Hosen",
                Experties = "Gyne,Chest,bone",
                HscCertificate = "www.aws.com",
                SSCCertificate = "www.aws.com",
                MedicalIdCard = "www.google.com",
                MedicalSchoolCertificate = "www.amar.com",
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            });
        }
    }
}
