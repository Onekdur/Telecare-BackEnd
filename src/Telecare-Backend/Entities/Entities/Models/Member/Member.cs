using Microsoft.AspNetCore.Identity;

namespace Entities.Models.Member
{
    public class Member : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public bool IsDeactivate { get; set; }
        public RelationshipStatus RelationShipStatus { get; set; }

    }
}
