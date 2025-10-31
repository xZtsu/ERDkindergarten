using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ravikulastus
    {


        
        public Guid Id { get; set; }
        public DateOnly Kuupaev {  get; set; }
        public string? Kirjeldus { get; set; }


  


    }
}
