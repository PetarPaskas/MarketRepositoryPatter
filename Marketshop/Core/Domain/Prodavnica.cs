using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class Prodavnica
    //Ubaci da se moze pratiti i kolicina raspolozivih proizvoda u prodavnici

    {
        public int Id { get; set; }
        public string Adresa { get; set; }

        public ICollection<RadnikRadnoMesto> Radnici { get; set; }
        public ICollection<Proizvod> Proizvodi { get; set; }
    }
}
