using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class KupacConfiguration :EntityTypeConfiguration<Kupac> 
    {
        public KupacConfiguration()
        {
            ToTable("Kupci");

            Property(k => k.Ime)
                .IsRequired()
                .HasMaxLength(20);

            Property(k => k.Prezime)
                .IsRequired()
                .HasMaxLength(20);

            Property(k => k.Adresa)
                .IsRequired()
                .HasMaxLength(150);

            Property(k => k.Bodovi)
                .IsRequired();
                
        }
    }
}
