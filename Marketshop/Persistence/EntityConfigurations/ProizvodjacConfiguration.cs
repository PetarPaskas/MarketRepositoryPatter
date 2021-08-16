using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class ProizvodjacConfiguration :EntityTypeConfiguration<Proizvodjac>
    {
        public ProizvodjacConfiguration()
        {
            ToTable("Proizvodjaci");

            Property(p => p.Naziv)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
