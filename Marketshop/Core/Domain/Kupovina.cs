using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class Kupovina
    {
        public int Id { get; set; }
        public int KupacId { get; set; }
        public double UkupnoNovcaPlaceno { get; set; }
        public string Komentar { get; set; }
        public DateTime DatumKupovine { get; set; }
        public bool? Povuceno { get; set; }
        public DateTime? DatumPovlacenja { get; set; }

        public Kupac Kupac { get; set; }
        
        public ICollection<ProizvodKupovina> Proizvodi { get; set; }
    }
}
