using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class Akcija
    {
        public int Id { get; set; }
        public int Popust { get; set; }
        public string Opis { get; set; }
        public int DuzinaTrajanja { get; set; }

        public ICollection<ProizvodAkcija> ProizvodiNaAkciji { get; set; }
    }
}
