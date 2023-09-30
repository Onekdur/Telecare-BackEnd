using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorRequestConfiguration : IEntityTypeConfiguration<DoctorRequest>
    {
        public void Configure(EntityTypeBuilder<DoctorRequest> builder)
        {
            builder.HasKey<DoctorRequest>();
            builder.HasData(new DoctorRequest()
            {
                
            });
        }
    }
}
