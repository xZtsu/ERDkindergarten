namespace DatabaseTask.Core.Domain
{
    public class Absense
    {
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; } = string.Empty;

        public IEnumerable<Group> Groups { get; set; } 
            = new List<Group>();
    }
}
