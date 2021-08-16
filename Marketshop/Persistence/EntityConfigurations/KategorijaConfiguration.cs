using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class KategorijaConfiguration : EntityTypeConfiguration<Kategorija>
    {
        public KategorijaConfiguration()
        {
            ToTable("Kategorije");

            Property(k => k.Naziv).IsRequired().HasMaxLength(150);

        
        }
    }
}
