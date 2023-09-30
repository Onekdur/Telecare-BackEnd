namespace Telecare.Domain.Entities.User.Doctor
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Experties { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public bool IsDeactivate { get; set; } = false;
        public bool IsBlock { get; set; } = false;
        public bool isActive { get; set; } = false;
    }
}
