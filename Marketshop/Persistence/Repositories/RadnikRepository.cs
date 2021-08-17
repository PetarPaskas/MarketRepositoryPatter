using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;
using Marketshop.Core.Repositories;
using System.Data.Entity;

namespace Marketshop.Persistence.Repositories
{
    class RadnikRepository : Repository<Radnik>, IRadnikRepository
    {
        private MarketContext Context { get { return _context as MarketContext; } }
        public RadnikRepository(MarketContext context)
            :base(context)
        {

        }

        public IEnumerable<Radnik> PretraziRadnikePoZanimanju(string zanimanje)
        {
            var radnici = Context.Radnici.Include(r => r.RadnikRadnoMesto.RadnoMesto).ToList();

            return radnici.Where(r => r.RadnikRadnoMesto.RadnoMesto.Pozicija == zanimanje);
        }

        public IEnumerable<Radnik> RadniciUnutarJedneProdavnice(int idProdavnice)
        {
            var radnici = Context.Radnici.Include(r => r.RadnikRadnoMesto).ToList();

            return radnici.Where(r => r.RadnikRadnoMesto.ProdavnicaId == idProdavnice);
        }

        public Radnik SveInfrmacijeJednogRadnika(int idRadnika)
        {
            var radnik = Context.Radnici
                        .Where(r => r.Id == idRadnika)
                        .Include(r => r.RadnikRadnoMesto.Prodavnica)
                        .Include(r => r.RadnikRadnoMesto.RadnoMesto)
                        .Include(r=>r.Ugovor)
                        .FirstOrDefault();
            if (radnik != null)
                return radnik;
            else
                throw new Exception("Nije pronadjen radnik sa tim ID-em");
        }
    }
}
