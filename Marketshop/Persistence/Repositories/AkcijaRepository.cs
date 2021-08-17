using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;
using Marketshop.Core.Repositories;

namespace Marketshop.Persistence.Repositories
{
    class AkcijaRepository : Repository<Akcija>, IAkcijaRepository
    {
        private MarketContext Context { get { return _context as MarketContext;  } }
        public AkcijaRepository(MarketContext context)
            :base(context)
        {

        }
    }
}
