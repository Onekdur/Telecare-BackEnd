namespace Entities.Models.Friends
{
    public class Friends
    {
        public Guid ID { get; set; }
        public Guid FriendsID { get; set; }
        public bool Block { get; set; }
        public bool MessageBlock { get; set; }
        public bool BlockFromMe { get; set; }
        public bool BlockFromFriend { get; set; }
        public bool MessageFromME { get; set; }
        public bool MessageFromFriend { get; set; }

    }
}
