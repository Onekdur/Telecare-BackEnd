using Entities.Models.Friends;
using Entities.Models.Members;
using Microsoft.EntityFrameworkCore;
using Telecare.Domain.Entities.Admins;
using Telecare.Domain.Entities.User.Doctor;

namespace Telecare.Application.Contract
{
    public interface IApplicationDbContext: IDisposable,IAsyncDisposable
    {
        DbSet<Member> Members { get; set; }
        public DbSet<CoverPhoto> CoverPhotos { get; set; }
        public DbSet<ProfilePhoto> ProfilePhotos { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<FriendRequest> FriendRequests { get; set; }
        public DbSet<SendingRequest> SendingRequests { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
       // public DbSet<DoctorRequest>  DoctorRequests { get; set; }
        public DbSet<DoctorFollower>  DoctorFollowers { get; set; }
    }
}
