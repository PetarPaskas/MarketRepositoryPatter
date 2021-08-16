using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class Proizvod
    {
        public int Id { get; set; }

        public int ProizvodjacId { get; set; }
        public int KategorijaId { get; set; }

        public string Naziv { get; set; }
        public double Cena { get; set; }
        public int Tezina { get; set; }
        public JedinicaEnum JedinicaTezine { get; set; }
        public int Bodovi { get; set; }
        public bool NaAkciji { get; set; }

        public Proizvodjac Proizvodjac { get; set; }
        public Kategorija Kategorija { get; set; }
        public ProizvodAkcija ProizvodNaAkciji { get; set; }

        public ICollection<ProizvodKupovina> Kupovine { get; set; }
        public ICollection<Prodavnica> Prodavnice { get; set; }
        
    }
}
