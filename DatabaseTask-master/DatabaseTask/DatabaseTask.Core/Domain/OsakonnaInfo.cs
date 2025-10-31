using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class OsakonnaInfo
    {
        public Guid Id { get; set; }
        public IEnumerable<Osakond> Osakonds { get; set; }
    = new List<Osakond>();
        public string Asukoht {  get; set; }
        public int KontaktTelefon { get; set; }
    }
}
