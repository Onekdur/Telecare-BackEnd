using Entities.Models.Members;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Telecare.Domain.Enum;

namespace Telecare.Persistance.Contexts.Configuration.MemberConfigurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(m => m.FirstName)
                .HasMaxLength(50);

            builder.Property(m => m.LastName)
                .HasMaxLength(50);

            //Ignore some builtin properties
            builder.Ignore(e => e.NormalizedUserName);
            builder.Ignore(e => e.UserName);
            builder.Ignore(e => e.SecurityStamp);
            builder.Ignore(e => e.ConcurrencyStamp);
            builder.Ignore(e => e.TwoFactorEnabled);
            builder.Ignore(e => e.LockoutEnabled);
            builder.Ignore(e => e.LockoutEnd);
            builder.Ignore(e => e.AccessFailedCount);

            //configure some constraint using flunt api
            builder.Property(e => e.GenDer)
                .HasConversion<string>();

            builder.Property(e => e.RelationShipStatus)
            .HasConversion<string>();

            //seed data
            builder.HasData(new Member()
            {
                Id = new Guid("0E1C1417-8DC0-4E9D-834D-89A889D2FB82"),
                Email = "mdsojibhosen444@gmail.com",
                GenDer = Gender.Male,
                FirstName = "Md Sojib",
                LastName = "Khan",
                RelationShipStatus = RelationshipStatus.Single,
                PhoneNumber = "01778553706",
                IsDeactivate = false,
                PasswordHash = "dhsgdwe323",
                EmailConfirmed = true,
            });
        }
    }
}
