using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models.Member
{
    public class Member : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public bool IsDeactivate { get; set; }
        public RelationshipStatus? RelationShipStatus { get; set; }
        public Address? Address { get; set; }
    }
}
