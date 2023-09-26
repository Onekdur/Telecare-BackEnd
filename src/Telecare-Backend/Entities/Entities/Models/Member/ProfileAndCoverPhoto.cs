namespace Entities.Models.Member
{
    public class ProfilePhoto
    {
        public Guid Id { get; set; }
        public string profilePhotoLink { get; set; }
        public bool IsPresent { get; set; }
    }
}
