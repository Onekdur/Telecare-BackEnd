namespace Entities.Models.Member
{
    public class Member
    {
        public Guid MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public bool IsDeactivate { get; set; }
        public RelationshipStatus RelationShipStatus { get; set; }

    }
}
