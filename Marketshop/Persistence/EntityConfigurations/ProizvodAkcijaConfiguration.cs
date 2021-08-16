using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class ProizvodAkcijaConfiguration :EntityTypeConfiguration<ProizvodAkcija>
    {
        public ProizvodAkcijaConfiguration()
        {
            ToTable("ProizvodiNaAkciji");

            HasRequired(pa => pa.Proizvod)
                 .WithOptional(p => p.ProizvodNaAkciji);
        }
    }
}
