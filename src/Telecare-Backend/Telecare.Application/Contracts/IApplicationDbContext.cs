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
        DbSet<TEntity> Dbset<TEntity>() where TEntity : class;
        DbSet<Member> Members { get; set; }
        DbSet<CoverPhoto> CoverPhotos { get; set; }
        DbSet<ProfilePhoto> ProfilePhotos { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Work> Works { get; set; }
        DbSet<Education> Educations { get; set; }
        DbSet<Friend> Friends { get; set; }
        DbSet<FriendRequest> FriendRequests { get; set; }
        DbSet<SendingRequest> SendingRequests { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<Doctor> Doctors { get; set; }
        DbSet<DoctorRequest>  DoctorRequests { get; set; }
        DbSet<DoctorFollower>  DoctorFollowers { get; set; }
        DbSet<DoctorPatient>  DoctorPatients { get; set; }
        DbSet<DoctorComment> DoctorComments { get; set; }
        DbSet<DoctorPatientComplain> PatientComplains { get; set; }
        DbSet<DoctorProfile> DoctorProfiles { get; set; }
        //post
        DbSet<Post> Posts { get; set; }
        DbSet<Photo> Photos { get; set; }
        DbSet<PhotoLike> PhotoLikes { get; set; }
        DbSet<PhotoComment> PhotoComments { get; set; }
        //public DbSet<PhotoCommentLike> PhotoCommentLikes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
