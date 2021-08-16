using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class KupovinaConfiguration : EntityTypeConfiguration<Kupovina>
    {
        public KupovinaConfiguration()
        {
            ToTable("Kupovine");

            HasRequired(k => k.Kupac)
                .WithMany(kp => kp.Kupovine)
                .HasForeignKey(k=>k.KupacId);

        }
    }
}
