using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class ProizvodKupovinaConfiguration : EntityTypeConfiguration<ProizvodKupovina>
    {
        public ProizvodKupovinaConfiguration()
        {
            ToTable("KupljeniProizvodi");

            HasRequired(kp => kp.Proizvod)
                .WithMany(p => p.Kupovine)
                .HasForeignKey(kp=>kp.ProizvodId);

            HasRequired(kp => kp.Kupovina)
                .WithMany(k => k.Proizvodi)
                .HasForeignKey(kp => kp.KupovinaId);

        }
    }
}
