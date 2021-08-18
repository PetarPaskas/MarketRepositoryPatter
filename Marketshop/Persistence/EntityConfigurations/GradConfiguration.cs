using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Marketshop.Core.Domain;

namespace Marketshop.Persistence.EntityConfigurations
{
    class GradConfiguration : EntityTypeConfiguration<Grad>
    {
        public GradConfiguration()
        {
            ToTable("Gradovi");

            HasKey(g => g.Id);

            HasMany(g => g.Prodavnice)
                .WithRequired(p => p.Grad)
                .HasForeignKey(p => p.GradId);


            Property(g => g.Naziv)
                .HasMaxLength(150)
                .IsRequired();

        }
    }
}
