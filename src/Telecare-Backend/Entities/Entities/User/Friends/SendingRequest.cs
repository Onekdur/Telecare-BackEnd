using Entities.Models.Members;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Friends
{
    public class SendingRequest
    {
        public Guid SendingRequestId { get; set; }
        public Guid SendFriendRequestUserID { get; set; }
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
