using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class MaaratudRavimid
    {
        public Guid Id { get; set; }

        public string Toimeaine { get; set; }
        public string Annus {  get; set; }
        public IEnumerable<Ravikulastus> Ravikulastus { get; set; }
= new List<Ravikulastus>();

    }
}
