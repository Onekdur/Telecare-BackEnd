using Entities.Models.Members;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.Friends
{
    public class Friend
    {
        [Key]
        public Guid FriendId{ get; set; }
        public Guid FriendUserId { get; set; }
        public bool Block { get; set; } = false;
        public bool MessageBlock { get; set; } = false;
        public bool BlockFromMe { get; set; } = false;
        public bool BlockFromFriend { get; set; } = false;
        public bool MessageBlockFromME { get; set; } = false;
        public bool MessageBlockFromFriend { get; set; } = false;
        [ForeignKey("MemberId")]
        public Guid MemberId { get; set; }
        public Member Member { get; set; }
    }
}
