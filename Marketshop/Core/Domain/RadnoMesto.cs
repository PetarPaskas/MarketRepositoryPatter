using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketshop.Core.Domain
{
    class RadnoMesto
    {
        public int Id { get; set; }
        public string Pozicija { get; set; }

        public ICollection<RadnikRadnoMesto> Radnici { get; set; }
    }
}
