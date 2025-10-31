using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Patsient
    {
        public Guid Id { get; set; }
        public int Isikukood { get; set; }
        public string Nimi { get; set; }
        public DateOnly Sunnikuupaev {  get; set; }
        public int KontaktTelefon {  get; set; }
        public string Address { get; set; }
        public IEnumerable<Ravikulastus> Ravikulastus { get; set; }
= new List<Ravikulastus>();
    }
}
