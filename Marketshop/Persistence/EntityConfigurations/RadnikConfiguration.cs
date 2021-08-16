using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class RadnikConfiguration : EntityTypeConfiguration<Radnik>
    {
        public RadnikConfiguration()
        {
            ToTable("Radnici");

            Property(r => r.Ime).IsRequired().HasMaxLength(20);
            Property(r => r.Prezime).IsRequired().HasMaxLength(20);
           
                
        }
    }
}
