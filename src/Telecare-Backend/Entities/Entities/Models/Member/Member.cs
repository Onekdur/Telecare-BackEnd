using Microsoft.AspNetCore.Identity;

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
        public List<Education>? Educations { get; set; }
    }
}
