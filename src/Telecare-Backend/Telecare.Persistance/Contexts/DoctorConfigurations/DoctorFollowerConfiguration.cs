using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorFollowerConfiguration : IEntityTypeConfiguration<DoctorFollower>
    {
        public void Configure(EntityTypeBuilder<DoctorFollower> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Doctor)
                .WithMany(e => e.DoctorFollowers)
                .HasForeignKey(e => e.DoctorId);

            builder.HasOne(e => e.Member)
                .WithMany(e => e.DoctorFollowers)
                .HasForeignKey(e => e.FollowerId);

            builder.HasData(new DoctorFollower()
            {
                Id = Guid.NewGuid(),
                FollowerId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82"),
                DoctorId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB85")
            }); ;
        }
    }
}
