namespace Entities.Models.Member
{
    public class Education
    {
        public Guid Id { get; set; }
        public string SchoolName { get; set; }
        public string Degree { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public bool CureentlyRunnig { get; set; }
        public string Description { get; set; }
        public Member Member { get; set; }
    }
}
