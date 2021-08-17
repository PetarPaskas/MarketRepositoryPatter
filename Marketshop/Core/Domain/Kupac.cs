using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Model;

namespace Marketshop.Core.Domain
{
    
    class Kupac
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public int Bodovi { get; set; }

        public ICollection<Kupovina> Kupovine { get; set; }
        public IList<ProizvodKorpa> Korpa = new List<ProizvodKorpa>();
      
        public int BrojProizvodaKorpe()
        {
            return Korpa.Count;
        }

        public void NapuniKorpu(Proizvod proizvod, byte? kolicina, int? tezina, JedinicaEnum? jedinica)
        {
            tezina = tezina ?? proizvod.Tezina;
            kolicina = kolicina ?? 1;
            jedinica = jedinica ?? proizvod.JedinicaTezine;

            ProizvodKorpa DodatiProizvod = new ProizvodKorpa(proizvod,(byte)kolicina,(int)tezina,(JedinicaEnum)jedinica);
            Korpa.Add(DodatiProizvod);
        }

        public void IzbrisiIzKorpe(int clan)
        {
            Korpa.RemoveAt(clan);
        }

        public void PrikaziKorpu()
        {
            //Mozda vratiti niz "ispisa" kao rezultat i na taj nacin omoguciti paging sadrzaja korpe
            if(Korpa.Count > 0)
            for(int i = 0; i < Korpa.Count; i++) 
            {
                //Stavi nesto kao "na meru" da prepoznas da li je na merenje proizvod
                ProizvodKorpa ProizvodKorpe = Korpa[i];
                double cena;
                if (ProizvodKorpe.Proizvod.Naziv.Contains("Rinfuz"))
                    cena = ProizvodKorpe.Kolicina * (ProizvodKorpe.Proizvod.Cena * ProizvodKorpe.Tezina);
                else cena = ProizvodKorpe.Proizvod.Cena;
                string ispis = $@"   {i}--- Proizvod {i+1}: {ProizvodKorpe.Proizvod.Naziv} 
                                                  Kolicina: {ProizvodKorpe.Kolicina}
                                                    Tezina: {ProizvodKorpe.Tezina}{Korpa[i].Jedinica}
                                                      Cena: {cena}

                                                                    ";
                Console.WriteLine(ispis);
            }
            else
                Console.WriteLine($"Korpa kupca {this.Ime} je prazna");
        }

        public void PrikaziJednuKupovinu(int clan)
        {
            ProizvodKorpa ProizvodKorpe = Korpa[clan];
            double cena;
            if (ProizvodKorpe.Proizvod.Naziv.Contains("Rinfuz"))
                cena = ProizvodKorpe.Kolicina * (ProizvodKorpe.Proizvod.Cena * ProizvodKorpe.Tezina);
            else cena = ProizvodKorpe.Proizvod.Cena;

            string ispis = $@"   {clan}--- Proizvod {clan + 1}: {ProizvodKorpe.Proizvod.Naziv} 
                                                  Kolicina: {ProizvodKorpe.Kolicina}
                                                    Tezina: {ProizvodKorpe.Tezina}{Korpa[clan].Jedinica}
                                                      Cena: {cena}

                                                                    ";
            Console.WriteLine(ispis);
        }

        public void KupiIzKorpe()
        {//Ovde cu verovatno morati proslediti UnitOfWork da bi ovo funkcionisalo
            throw new NotImplementedException();
        }

        public void IsprazniKorpu()
        {
            Korpa.Clear();
            Console.WriteLine("Korpa je ispraznjena");
        }
    }
}
