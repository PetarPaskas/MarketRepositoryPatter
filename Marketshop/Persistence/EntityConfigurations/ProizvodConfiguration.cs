using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class ProizvodConfiguration :EntityTypeConfiguration<Proizvod>
    {
        public ProizvodConfiguration()
        {
            ToTable("Proizvodi");

            HasRequired(p => p.Proizvodjac)
                .WithMany(p => p.Proizvodi)
                .HasForeignKey(p=>p.ProizvodjacId);

            HasRequired(p => p.Kategorija)
                .WithMany(k => k.Proizvodi)
                .HasForeignKey(p=>p.KategorijaId);


            Property(p => p.Naziv)
                .IsRequired()
                .HasMaxLength(150);

            Ignore(p => p.NaAkciji);


        }
    }
}
