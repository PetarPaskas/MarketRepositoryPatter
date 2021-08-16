using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class RadnikRadnoMestoConfiguration : EntityTypeConfiguration<RadnikRadnoMesto>
    {
        public RadnikRadnoMestoConfiguration()
        {
            ToTable("RadnaMestaRadnika");

            HasRequired(rm => rm.Radnik)
                .WithRequiredDependent(r => r.RadnikRadnoMesto);

            HasRequired(rm => rm.RadnoMesto)
                .WithMany(mr => mr.Radnici)
                .HasForeignKey(rm => rm.RadnoMestoId);

            HasRequired(rm => rm.Prodavnica)
                .WithMany(p => p.Radnici)
                .HasForeignKey(rm => rm.ProdavnicaId);
        }
    }
}
