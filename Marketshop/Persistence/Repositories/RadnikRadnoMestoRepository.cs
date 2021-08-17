using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Repositories;
using Marketshop.Persistence.Repositories;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.Repositories
{
    class RadnikRadnoMestoRepository : Repository<RadnikRadnoMesto>, IRadnikRadnoMestoRepository 
    {
        private MarketContext Context { get { return _context as MarketContext; } }

        public RadnikRadnoMestoRepository(MarketContext context)
        : base(context)
        {
        }
    }
}
