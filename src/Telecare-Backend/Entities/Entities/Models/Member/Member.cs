using Microsoft.AspNetCore.Identity;
using Telecare.Domain.Entities.Enum;

namespace Entities.Models.Member
{
    public class Member : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender GenDer { get; set; }
        public bool IsDeactivate { get; set; } = false;
        public RelationshipStatus? RelationShipStatus { get; set; } = RelationshipStatus.Single;
        public Address? Addresses { get; set; }
        public List<ProfilePhoto>? ProfilePicture { get; set; }
        public List<CoverPhoto>? CoverPicture { get; set; }
        public List<Education>? Educations { get; set; }
        public List<Work>? Works { get; set; }
    }
}
