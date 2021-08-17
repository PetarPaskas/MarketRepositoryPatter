using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Repositories;
using Marketshop.Persistence.Repositories;
using Marketshop.Core.Domain;
using System.Data.Entity;

namespace Marketshop.Persistence.Repositories
{
    class RadnoMestoRepository : Repository<RadnoMesto>, IRadnoMestoRepository
    {
        private MarketContext Context { get { return _context as MarketContext; } }

        public RadnoMestoRepository(MarketContext context)
        :base(context)
        {
        }

        public IEnumerable<IGrouping<string,RadnoMesto>> SviRadniciGrupisaniPoZanimanjima()
        {
              return Context.RadnaMesta
                        .Include(rm => rm.Radnici)
                        .ToList()
                        .GroupBy(rm => rm.Pozicija);
                        
        }
    }
}
