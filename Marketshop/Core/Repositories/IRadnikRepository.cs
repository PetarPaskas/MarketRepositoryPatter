using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marketshop.Core.Domain;

namespace Marketshop.Core.Repositories
{
    interface IRadnikRepository : IRepository<Radnik>
    {
        IEnumerable<Radnik> RadniciUnutarJedneProdavnice(int idProdavnice);
        IEnumerable<Radnik> PretraziRadnikePoZanimanju(string zanimanje);
        Radnik SveInfrmacijeJednogRadnika(int idRadnika);
    }
}
