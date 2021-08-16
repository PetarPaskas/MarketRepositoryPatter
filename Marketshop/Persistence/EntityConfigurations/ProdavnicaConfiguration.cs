using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class ProdavnicaConfiguration :EntityTypeConfiguration<Prodavnica>
    {
        public ProdavnicaConfiguration()
        {
            ToTable("Prodavnice");

            HasMany(p => p.Proizvodi)
                .WithMany(p => p.Prodavnice)
                .Map(m => 
                { 
                    m.ToTable("ProizvodiProdavnice");
                    m.MapLeftKey("ProizvodId");
                    m.MapRightKey("ProdavnicaId");
                }
                );

            Property(p => p.Adresa)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
