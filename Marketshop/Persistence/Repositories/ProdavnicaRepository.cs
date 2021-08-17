using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;
using Marketshop.Core.Repositories;

namespace Marketshop.Persistence.Repositories
{
    class ProdavnicaRepository : Repository<Prodavnica>, IProdavnicaRepository
    {
        private MarketContext Context { get { return _context as MarketContext; } }
        public ProdavnicaRepository(MarketContext context)
            :base(context)
        {

        }
    }
}
