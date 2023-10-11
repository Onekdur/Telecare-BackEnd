using Entities.Models.Friends;
using Entities.Models.Post.PostContent.Photo;
using Microsoft.AspNetCore.Identity;
using Telecare.Domain.Entities.Admins;
using Telecare.Domain.Entities.User.Doctor;
using Telecare.Domain.Enum;

namespace Entities.Models.Members
{
    public class Member : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender GenDer { get; set; }
        public bool IsDeactivate { get; set; } = false;
        public RelationshipStatus? RelationShipStatus { get; set; } = RelationshipStatus.Single;
        public Admin Admin { get; set; }
        public DoctorProfile DoctorProfile { get; set; }
        public List<ProfilePhoto> ProfilePicture { get; set; }
        public List<CoverPhoto> CoverPicture { get; set; }
        public List<Education> Educations { get; set; }
        public List<Work> Works { get; set; }
        public List<Friend> Friends { get; set; }
        public List<FriendRequest> FriendRequests { get; set; }
        public List<SendingRequest> SendingRequests { get; set; }
        public List<DoctorRequest> DoctorRequests { get; set; }
        public List<DoctorPatient> DoctorPatients { get; set; }
        public DoctorComment DoctorComment { get; set; }
        public List<DoctorFollower> DoctorFollowers { get; set; }
        public List<DoctorPatientComplain> DoctorPatientComplains { get; set; }
        //post
        public List<PhotoLike> PhotoLikes { get; set; }
        public List<PhotoComment> PhotoComments { get; set; }
        public List<PhotoCommentLike> PhotoCommentLikes { get; set; }
        //public List<PhotoCommentPicture> PhotoCommentPictures { get; set; }
    }
}
