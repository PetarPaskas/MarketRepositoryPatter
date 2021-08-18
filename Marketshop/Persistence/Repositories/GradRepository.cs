using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;
using Marketshop.Core.Repositories;

namespace Marketshop.Persistence.Repositories
{
    class GradRepository : Repository<Grad>, IGradRepository
    {
        private MarketContext Context { get { return _context as MarketContext; } }
        public GradRepository(MarketContext context)
            :base(context)
        {

        }
    }
}
