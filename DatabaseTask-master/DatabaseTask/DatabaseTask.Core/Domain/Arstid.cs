using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Arstid
    {
        public Guid Id { get; set; }
        public string Nimi { get; set; }
        public string Eriala { get; set; }
        public int TooTelefon { get; set; }


        public IEnumerable<Ravikulastus> Ravikulastus{ get; set; }
  = new List<Ravikulastus>();
    }
}
