using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class UgovorConfiguration :EntityTypeConfiguration<Ugovor>
    {
        public UgovorConfiguration()
        {
            ToTable("Ugovori");

            Property(u => u.Plata).IsRequired();

            HasRequired(u => u.Radnik)
                .WithRequiredDependent(r => r.Ugovor);
        }
    }
}
