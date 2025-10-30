using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ChildGroupHistory
    {
        public Guid Id { get; set; }
        public DateTime Start {  get; set; }
        public DateTime EndDate { get; set; }
        
        public IEnumerable<Child> Childs { get; set; }
            = new List<Child>();
        
        public IEnumerable<Group> Groups { get; set; }
            = new List<Group>();
    }
}
