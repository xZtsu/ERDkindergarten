namespace DatabaseTask.Core.Domain
{
    public class JobTitle
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //public IEnumerable<Employee> Employees { get; set; } 
        //    = new List<Employee>();
    }
}
