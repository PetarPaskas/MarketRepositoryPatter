using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Marketshop.Core.Domain;
using Marketshop.Persistence.EntityConfigurations;

namespace Marketshop.Persistence
{
    class MarketContext :DbContext
    {

        public DbSet<Prodavnica> Prodavnice { get; set; } //

        public DbSet<Kupac> Kupci { get; set; } //Unutar UP() postaviti Kupac=>Bodovi=>DefaultValue=>0
        public DbSet<Kupovina> Kupovine { get; set; } //
        public DbSet<ProizvodKupovina> KupljeniProizvodi { get; set; } //

        public DbSet<Radnik> Radnici { get; set; } //Podesiti Radnik Ugovor ForeignKey
        public DbSet<RadnoMesto> RadnaMesta { get; set; } //Podesen FKRadnikRadnoMesto
        public DbSet<Ugovor> Ugovori { get; set; } //Staviti da plata mora biti >31k
        public DbSet<RadnikRadnoMesto> RadnaMestaRadnika { get; set; } //Ne mozes podesiti 1To1 HasForeignKey, wat??

        public DbSet<Proizvod> Proizvodi { get; set; } //
        public DbSet<Proizvodjac> Proizvodjaci { get; set; } //
        public DbSet<Kategorija> Kategorije { get; set; } //
        public DbSet<Akcija> Akcije { get; set; } //
        public DbSet<ProizvodAkcija> ProizvodiNaAkciji { get; set; } //

        public MarketContext()
            :base("name=MarketConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AkcijaConfiguration());
            modelBuilder.Configurations.Add(new KategorijaConfiguration());
            modelBuilder.Configurations.Add(new KupacConfiguration());
            modelBuilder.Configurations.Add(new KupovinaConfiguration());
            modelBuilder.Configurations.Add(new ProdavnicaConfiguration());
            modelBuilder.Configurations.Add(new ProizvodAkcijaConfiguration());
            modelBuilder.Configurations.Add(new ProizvodConfiguration());
            modelBuilder.Configurations.Add(new ProizvodjacConfiguration());
            modelBuilder.Configurations.Add(new ProizvodKupovinaConfiguration());
            modelBuilder.Configurations.Add(new RadnikConfiguration());
            modelBuilder.Configurations.Add(new RadnikRadnoMestoConfiguration());
            modelBuilder.Configurations.Add(new RadnoMestoConfiguration());
            modelBuilder.Configurations.Add(new UgovorConfiguration());
            modelBuilder.Configurations.Add(new GradConfiguration());

        }
    }
}
