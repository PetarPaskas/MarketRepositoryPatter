using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;

namespace Marketshop.Core.Repositories
{
    interface IRadnoMestoRepository : IRepository<RadnoMesto>
    {
        IEnumerable<IGrouping<string, RadnoMesto>> SviRadniciGrupisaniPoZanimanjima();
    }
}
