namespace Entities.Models.Friends
{
    public class FriendRequest
    {
        public Guid Id { get; set; }
        public Guid RequestID { get; set; }
        public bool Accept { get; set; }
        public bool Pending { get; set; }
        public bool Reject { get; set; }
        public bool IsSeen { get; set; }
    }
}
