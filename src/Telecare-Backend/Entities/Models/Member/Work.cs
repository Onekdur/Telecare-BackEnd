namespace Entities.Models
{
    public class Work
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ComapnyName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool CurrentlyRunning { get; set; }
        public bool Description { get; set; }
        public Member Member { get; set; }
    }
}
