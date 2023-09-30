namespace Telecare.Domain.Entities.User.Doctor
{
    public class DoctorFollower
    {
        public Guid Id { get; set; }
        public Guid FollowerId { get; set; }
    }
}
