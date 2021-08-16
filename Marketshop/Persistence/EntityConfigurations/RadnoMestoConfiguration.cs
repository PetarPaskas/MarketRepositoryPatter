using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class RadnoMestoConfiguration : EntityTypeConfiguration<RadnoMesto>
    {
        public RadnoMestoConfiguration()
        {
            ToTable("RadnaMesta");

            HasMany(rm => rm.Radnici)
                .WithRequired(r => r.RadnoMesto);

            Property(rm => rm.Pozicija).IsRequired().HasMaxLength(100);

        }
    }
}
