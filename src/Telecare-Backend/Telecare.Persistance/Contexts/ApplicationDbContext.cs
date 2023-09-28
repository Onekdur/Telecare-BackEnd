using Entities.Models.Member;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Telecare.Application.Contract;
using Telecare.Persistance.Contexts.Configuration.MemberConfiguration;
using Telecare.Persistance.Contexts.Configuration.MemberConfigurations;

namespace Telecare.Persistance.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<Member, IdentityRole<Guid>, Guid>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MemberConfiguration());
            builder.ApplyConfiguration(new AddressConfiguration());
            builder.ApplyConfiguration(new EducationConfiguration());
            builder.ApplyConfiguration(new ProfilePictureConfiguration());
            builder.ApplyConfiguration(new CoverPictureConfiguration());
            builder.ApplyConfiguration(new WorkConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<CoverPhoto> CoverPhotos { get; set; }
        public DbSet<ProfilePhoto> ProfilePhotos { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}
