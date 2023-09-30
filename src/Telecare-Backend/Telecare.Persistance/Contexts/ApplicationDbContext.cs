using Entities.Models.Friends;
using Entities.Models.Members;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Telecare.Application.Contract;
using Telecare.Domain.Entities.Admins;
using Telecare.Domain.Entities.User.Doctor;
using Telecare.Persistance.Contexts.Configuration.AdminConfigurations;
using Telecare.Persistance.Contexts.Configuration.FriendsConfigurions;
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
            builder.ApplyConfiguration(new FriendConfiguration());
            builder.ApplyConfiguration(new FriendRequestConfiguration());
            builder.ApplyConfiguration(new SendingRequestConfigurtion());
            builder.ApplyConfiguration(new AdminConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<CoverPhoto> CoverPhotos { get; set; }
        public DbSet<ProfilePhoto> ProfilePhotos { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Friend> Friends { get ; set ; }
        public DbSet<FriendRequest> FriendRequests { get ; set ; }
        public DbSet<SendingRequest> SendingRequests { get ; set ; }
        public DbSet<Admin> Admins { get ; set ; }
        public DbSet<DoctorRequest> DoctorRequests { get ; set ; }
    }
}
