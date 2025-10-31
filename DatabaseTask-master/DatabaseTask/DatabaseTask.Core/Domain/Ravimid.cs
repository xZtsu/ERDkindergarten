using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ravimid
    {
        public Guid Id { get; set; }
        public string Ravim { get; set; }
        public IEnumerable<MaaratudRavimid> MaaratudRavimids{ get; set; }
= new List<MaaratudRavimid>();
    }
}
