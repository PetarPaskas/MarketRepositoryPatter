using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;

namespace Marketshop.Model
{
    class ProizvodKorpa
    {   
        public Proizvod Proizvod { get; set; }
        public byte Kolicina { get; set; }
        public int Tezina { get; set; }
        public JedinicaEnum Jedinica { get; set; }

        public ProizvodKorpa(Proizvod proizvod, byte kolicina, int tezina, JedinicaEnum jedinica)
        {
            Proizvod = proizvod;
            Kolicina = kolicina;
            Jedinica = jedinica;
            Tezina = tezina;

        }
    }
}
