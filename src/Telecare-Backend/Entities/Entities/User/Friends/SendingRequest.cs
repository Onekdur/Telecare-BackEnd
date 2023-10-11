using Entities.Models.Members;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Friends
{
    public class SendingRequest
    {
        public Guid Id { get; set; }
        public Guid SendFriendRequestId { get; set; }
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
