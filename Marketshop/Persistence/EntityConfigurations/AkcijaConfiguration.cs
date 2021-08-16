using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class AkcijaConfiguration : EntityTypeConfiguration<Akcija>
    {
        public AkcijaConfiguration()
        {
            ToTable("Akcije");

            Property(a => a.Opis).IsRequired().HasMaxLength(150);

            HasMany(a => a.ProizvodiNaAkciji)
                .WithRequired(p => p.Akcija)
                .HasForeignKey(p=>p.AkcijaId);
        }
    }
}
