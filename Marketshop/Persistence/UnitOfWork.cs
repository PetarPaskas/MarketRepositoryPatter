using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core;
using Marketshop.Core.Repositories;

namespace Marketshop.Persistence
{
    class UnitOfWork : IUnitOfWork
    {
        public IGradRepository Gradovi { get; set; }
        public IProdavnicaRepository Prodavnice { get; set; } //

        public IKupacRepository Kupci { get; set; } //
        public IKupovinaRepository Kupovine { get; set; } //
        public IProizvodKupovinaRepository KupljeniProizvodi { get; set; } //

        public IRadnikRepository Radnici { get; set; } //Podesiti Radnik Ugovor ForeignKey
        public IRadnoMestoRepository RadnaMesta { get; set; } //Podesen FKRadnikRadnoMesto
        public IUgovorRepository Ugovori { get; set; } //Staviti da plata mora biti >31k
        public IRadnoMestoRepository RadnaMestaRadnika { get; set; } //Ne mozes podesiti 1To1 HasForeignKey, wat??

        public IProizvodRepository Proizvodi { get; set; } //
        public IProizvodjacRepository Proizvodjaci { get; set; } //
        public IKategorijaRepository KategorijeProizvoda { get; set; } //
        public IAkcijaRepository Akcije { get; set; } //
        public IProizvodAkcijaRepository ProizvodiNaAkciji { get; set; } //

        private MarketContext _context;
        public UnitOfWork(MarketContext context)
        {
            _context = context;
        }
        public int SaveChanges()
        {
           return _context.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
