using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class ProizvodKupovina
    {
        public int Id { get; set; }

        public int ProizvodId { get; set; }
        public int KupovinaId { get; set; }

        public byte Kolicina { get; set; }
        public int Tezina { get; set; }
        public JedinicaEnum Jedinica { get; set; }

        public Proizvod Proizvod { get; set; }
        public Kupovina Kupovina { get; set; }
    }
}
