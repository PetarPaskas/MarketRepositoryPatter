using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class Radnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Ugovor Ugovor { get; set; }
        public RadnikRadnoMesto RadnikRadnoMesto { get; set; }
    }
}
