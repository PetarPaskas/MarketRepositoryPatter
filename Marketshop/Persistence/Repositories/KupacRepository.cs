using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;
using System.Data.Entity;
using Marketshop.Core.Repositories;

namespace Marketshop.Persistence.Repositories
{
    class KupacRepository : Repository<Kupac>, IKupacRepository
    {
        protected MarketContext Context { get { return _context as MarketContext; } }

        public KupacRepository(MarketContext context)
        :base(context)
        {
        }

        public IEnumerable<Kupac> KupciSaNjihovimKupovinama()
        {
            return Context.Kupci.Include(k => k.Kupovine).ToList();
        }

       
        public IEnumerable<Kupac> KupciSaNajviseBodova(int pageSize = 5, int pageIndex = 1)
        {
            return Context.Kupci.ToList().OrderByDescending(k => k.Bodovi).Skip((pageIndex-1)*pageSize).Take(pageSize);
        }
    }
}
