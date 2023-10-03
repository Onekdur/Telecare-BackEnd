﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Persistance.Contexts.DoctorConfigurations
{
    public class DoctorPatientConfiguration : IEntityTypeConfiguration<DoctorPatient>
    {
        public void Configure(EntityTypeBuilder<DoctorPatient> builder)
        {
            builder.HasKey(e => new { e.MemberId, e.DoctorId });

            builder.HasOne(e => e.Member)
                .WithMany(e => e.DoctorPatients)
                .HasForeignKey(e => e.MemberId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Doctor)
                .WithMany(e => e.DoctorPatients)
                .HasForeignKey(e => e.DoctorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new DoctorPatient()
            {
                MemberId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82"),
                DoctorId = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB85")
            });
        }
    }
}
