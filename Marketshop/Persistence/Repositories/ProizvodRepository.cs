using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;
using Marketshop.Core.Repositories;

namespace Marketshop.Persistence.Repositories
{
    class ProizvodRepository : Repository<Proizvod>, IProizvodRepository
    {
        private MarketContext Context { get { return _context as MarketContext; } }
        public ProizvodRepository(MarketContext context)
        : base(context)
        {

        }
    }
}
