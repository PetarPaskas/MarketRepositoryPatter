using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class Proizvodjac
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public ICollection<Proizvod> Proizvodi { get; set; }
    }
}
