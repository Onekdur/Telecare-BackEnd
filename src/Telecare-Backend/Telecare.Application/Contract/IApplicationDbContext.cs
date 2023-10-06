using Entities.Models.Friends;
using Entities.Models.Members;
using Entities.Models.Post;
using Entities.Models.Post.PostContent.Photo;
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
        public DbSet<DoctorRequest>  DoctorRequests { get; set; }
        public DbSet<DoctorFollower>  DoctorFollowers { get; set; }
        public DbSet<DoctorPatient>  DoctorPatients { get; set; }
        public DbSet<DoctorComment> DoctorComments { get; set; }
        public DbSet<DoctorPatientComplain> PatientComplains { get; set; }
        public DbSet<DoctorProfile> DoctorProfiles { get; set; }
        //post
        public DbSet<Post> Posts { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PhotoLike> PhotoLikes { get; set; }
        public DbSet<PhotoComment> PhotoComments { get; set; }
    }
}
