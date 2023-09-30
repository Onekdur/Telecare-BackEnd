using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorFollowerConfiguration : IEntityTypeConfiguration<DoctorFollower>
    {
        public void Configure(EntityTypeBuilder<DoctorFollower> builder)
        {
            builder.HasData(new DoctorFollower()
            {
                Id = Guid.NewGuid(),
                FollowerId = Guid.NewGuid(),
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82")
            });
        }
    }
}
