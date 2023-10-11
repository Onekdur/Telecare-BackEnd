using Entities.Models.Members;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Friends
{
    public class FriendRequest
    {
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
        public bool IsSeen { get; set; } = false;
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
