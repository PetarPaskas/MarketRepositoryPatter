using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class ProizvodAkcija
    {
        public int Id { get; set; }
        public int AkcijaId { get; set; }
        public int ProizvodId { get; set; }
        public double NovaCena { get; set; }
        public DateTime PocetakAkcije { get; set; }
        public DateTime KrajAkcije { get; set; }

        public Akcija Akcija { get; set; }
        public Proizvod Proizvod { get; set; }
    }
}
