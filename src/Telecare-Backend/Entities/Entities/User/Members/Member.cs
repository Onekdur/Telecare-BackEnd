using Microsoft.AspNetCore.Identity;
using Telecare.Domain.Entities.Enum;
using Entities.Models.Friends;
using Telecare.Domain.Entities.Admins;
using Telecare.Domain.Entities.User.Doctor;

namespace Entities.Models.Members
{
    public class Member : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender GenDer { get; set; }
        public bool IsDeactivate { get; set; } = false;
        public RelationshipStatus? RelationShipStatus { get; set; } = RelationshipStatus.Single;
        public Address Addresses { get; set; }
        public Admin Admins { get; set; }
        public List<ProfilePhoto> ProfilePicture { get; set; }
        public List<CoverPhoto> CoverPicture { get; set; }
        public List<Education> Educations { get; set; }
        public List<Work> Works { get; set; }
        public List<Friend> Friends { get; set; }
        public List<FriendRequest> FriendRequests { get; set; }
        public List<SendingRequest> SendingRequests { get; set; }
        public List<DoctorRequest> DoctorRequests { get; set; }
        public Doctor Doctor { get; set; }
        public DoctorPatient DoctorPatient { get; set; }
    }
}
