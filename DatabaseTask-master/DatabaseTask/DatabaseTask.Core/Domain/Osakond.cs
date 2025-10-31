using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
   public class Osakond
    {
        public Guid Id { get; set; }
        public string OsakonnaNimi { get; set; }
        public IEnumerable<Arstid> Arstids { get; set; }
= new List<Arstid>();
    }
}
