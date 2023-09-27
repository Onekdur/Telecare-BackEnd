using Entities.Models.Member;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Telecare.Persistance.Contexts.Configuration
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            //Ignore some builtin properties
            builder.Ignore(e => e.NormalizedUserName);
            builder.Ignore(e => e.UserName);
            builder.Ignore(e => e.SecurityStamp);
            builder.Ignore(e => e.ConcurrencyStamp);
            builder.Ignore(e => e.TwoFactorEnabled);
            builder.Ignore(e => e.LockoutEnabled);
            builder.Ignore(e => e.LockoutEnd);
            builder.Ignore(e => e.AccessFailedCount);
            builder.Ignore(e => e.PhoneNumberConfirmed);

            //configure some constraint using flunt api
            builder.Property(e => e.Gender)
                .HasConversion<string>();

            builder.Property(e => e.RelationShipStatus)
            .HasConversion<string>();

        }
    }
}
