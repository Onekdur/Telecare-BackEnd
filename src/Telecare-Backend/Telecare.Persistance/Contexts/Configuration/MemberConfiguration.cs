using Entities.Models.Member;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration
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
            builder.Property(e => e.Gender)
                .HasConversion<string>();

            builder.Property(e => e.RelationShipStatus)
            .HasConversion<string>();

        }
    }
}
