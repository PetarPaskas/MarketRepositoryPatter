using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class RadnikRadnoMesto
    {
        public int Id { get; set; }

        public int RadnikId { get; set; }
        public int RadnoMestoId { get; set; }
        public int ProdavnicaId { get; set; }

        public Radnik Radnik { get; set; }
        public RadnoMesto RadnoMesto { get; set; }
        public Prodavnica Prodavnica { get; set; }
    }
}
