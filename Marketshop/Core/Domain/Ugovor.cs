using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marketshop.Core.Domain
{
    class Ugovor
    {
        public int Id { get; set; }
        public int RadnikId { get; set; }
        public DateTime DatumPocetkaRada { get; set; }
        public DateTime? DatumKrajaRada { get; set; }
        public int DuzinaTrajanjaUgovora { get; set; }
        public double Plata { get; set; }

        public Radnik Radnik { get; set; }
    }
}
