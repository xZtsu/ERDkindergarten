using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Queues
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime RegDate { get; set; }

        public IEnumerable<Child> Childs { get; set; }
            =new List<Child>();

        public IEnumerable<Group> Groups { get; set; }
            = new List<Group>();
    }
}
