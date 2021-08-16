namespace Marketshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Akcije",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Popust = c.Int(nullable: false),
                        Opis = c.String(nullable: false, maxLength: 150),
                        DuzinaTrajanja = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProizvodiNaAkciji",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        AkcijaId = c.Int(nullable: false),
                        ProizvodId = c.Int(nullable: false),
                        NovaCena = c.Double(nullable: false),
                        PocetakAkcije = c.DateTime(nullable: false, defaultValueSql : "GETDATE()"),
                        KrajAkcije = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
               // .ForeignKey("dbo.Proizvodi", t => t.Id)
                .ForeignKey("dbo.Proizvodi", t => t.ProizvodId)
                .ForeignKey("dbo.Akcije", t => t.AkcijaId, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.AkcijaId)
                //
                .Index(t=>t.ProizvodId);
            
            CreateTable(
                "dbo.Proizvodi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProizvodjacId = c.Int(nullable: false),
                        KategorijaId = c.Int(nullable: false),
                        Naziv = c.String(nullable: false, maxLength: 150),
                        Cena = c.Double(nullable: false),
                        Tezina = c.Int(nullable: false),
                        JedinicaTezine = c.Byte(nullable: false),
                        Bodovi = c.Int(nullable: false, defaultValue:0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategorije", t => t.KategorijaId, cascadeDelete: true)
                .ForeignKey("dbo.Proizvodjaci", t => t.ProizvodjacId, cascadeDelete: true)
                .Index(t => t.ProizvodjacId)
                .Index(t => t.KategorijaId);
            
            CreateTable(
                "dbo.Kategorije",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KupljeniProizvodi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProizvodId = c.Int(nullable: false),
                        KupovinaId = c.Int(nullable: false),
                        Kolicina = c.Byte(nullable: false),
                        Tezina = c.Int(nullable: false),
                        Jedinica = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kupovine", t => t.KupovinaId, cascadeDelete: true)
                .ForeignKey("dbo.Proizvodi", t => t.ProizvodId, cascadeDelete: true)
                .Index(t => t.ProizvodId)
                .Index(t => t.KupovinaId);
            
            CreateTable(
                "dbo.Kupovine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KupacId = c.Int(nullable: false),
                        UkupnoNovcaPlaceno = c.Double(nullable: false),
                        Komentar = c.String(),
                        DatumKupovine = c.DateTime(nullable: false),
                        Povuceno = c.Boolean(),
                        DatumPovlacenja = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kupci", t => t.KupacId, cascadeDelete: true)
                .Index(t => t.KupacId);
            
            CreateTable(
                "dbo.Kupci",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false, maxLength: 20),
                        Prezime = c.String(nullable: false, maxLength: 20),
                        Adresa = c.String(nullable: false, maxLength: 150),
                        Bodovi = c.Int(nullable: false, defaultValue:0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prodavnice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adresa = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
           
            CreateTable(
                "dbo.RadnaMestaRadnika",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RadnikId = c.Int(nullable: false),
                        RadnoMestoId = c.Int(nullable: false),
                        ProdavnicaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prodavnice", t => t.ProdavnicaId, cascadeDelete: true)
                //.ForeignKey("dbo.Radnici", t => t.Id)
                .ForeignKey("dbo.Radnici", t => t.RadnikId)
                .ForeignKey("dbo.RadnaMesta", t => t.RadnoMestoId, cascadeDelete: true)
                //
                .Index(t => t.RadnikId)
                .Index(t => t.RadnoMestoId)
                .Index(t => t.ProdavnicaId);
            
            CreateTable(
                "dbo.Radnici",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(nullable: false, maxLength: 20),
                        Prezime = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ugovori",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RadnikId = c.Int(nullable: false),
                        DatumPocetkaRada = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        DatumKrajaRada = c.DateTime(),
                        DuzinaTrajanjaUgovora = c.Int(nullable: false),
                        Plata = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                //.ForeignKey("dbo.Radnici", t => t.Id)
                .ForeignKey("dbo.Radnici", t => t.RadnikId)
                //.Index(t => t.Id)
                .Index(t => t.RadnikId);
            
            CreateTable(
                "dbo.RadnaMesta",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pozicija = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proizvodjaci",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProizvodiProdavnice",
                c => new
                    {
                        ProizvodId = c.Int(nullable: false),
                        ProdavnicaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProizvodId, t.ProdavnicaId })
                .ForeignKey("dbo.Prodavnice", t => t.ProizvodId, cascadeDelete: true)
                .ForeignKey("dbo.Proizvodi", t => t.ProdavnicaId, cascadeDelete: true)
                .Index(t => t.ProizvodId)
                .Index(t => t.ProdavnicaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProizvodiNaAkciji", "AkcijaId", "dbo.Akcije");
            DropForeignKey("dbo.ProizvodiNaAkciji", "Id", "dbo.Proizvodi");
            DropForeignKey("dbo.Proizvodi", "ProizvodjacId", "dbo.Proizvodjaci");
            DropForeignKey("dbo.RadnaMestaRadnika", "RadnoMestoId", "dbo.RadnaMesta");
            DropForeignKey("dbo.RadnaMestaRadnika", "Id", "dbo.Radnici");
            DropForeignKey("dbo.Ugovori", "Id", "dbo.Radnici");
            DropForeignKey("dbo.RadnaMestaRadnika", "ProdavnicaId", "dbo.Prodavnice");
            DropForeignKey("dbo.ProizvodiProdavnice", "ProdavnicaId", "dbo.Proizvodi");
            DropForeignKey("dbo.ProizvodiProdavnice", "ProizvodId", "dbo.Prodavnice");
            DropForeignKey("dbo.KupljeniProizvodi", "ProizvodId", "dbo.Proizvodi");
            DropForeignKey("dbo.KupljeniProizvodi", "KupovinaId", "dbo.Kupovine");
            DropForeignKey("dbo.Kupovine", "KupacId", "dbo.Kupci");
            DropForeignKey("dbo.Proizvodi", "KategorijaId", "dbo.Kategorije");
            DropIndex("dbo.ProizvodiProdavnice", new[] { "ProdavnicaId" });
            DropIndex("dbo.ProizvodiProdavnice", new[] { "ProizvodId" });
            DropIndex("dbo.Ugovori", new[] { "Id" });
            DropIndex("dbo.RadnaMestaRadnika", new[] { "ProdavnicaId" });
            DropIndex("dbo.RadnaMestaRadnika", new[] { "RadnoMestoId" });
            DropIndex("dbo.RadnaMestaRadnika", new[] { "Id" });
            DropIndex("dbo.Kupovine", new[] { "KupacId" });
            DropIndex("dbo.KupljeniProizvodi", new[] { "KupovinaId" });
            DropIndex("dbo.KupljeniProizvodi", new[] { "ProizvodId" });
            DropIndex("dbo.Proizvodi", new[] { "KategorijaId" });
            DropIndex("dbo.Proizvodi", new[] { "ProizvodjacId" });
            DropIndex("dbo.ProizvodiNaAkciji", new[] { "AkcijaId" });
            DropIndex("dbo.ProizvodiNaAkciji", new[] { "Id" });
            DropTable("dbo.ProizvodiProdavnice");
            DropTable("dbo.Proizvodjaci");
            DropTable("dbo.RadnaMesta");
            DropTable("dbo.Ugovori");
            DropTable("dbo.Radnici");
            DropTable("dbo.RadnaMestaRadnika");
            DropTable("dbo.Prodavnice");
            DropTable("dbo.Kupci");
            DropTable("dbo.Kupovine");
            DropTable("dbo.KupljeniProizvodi");
            DropTable("dbo.Kategorije");
            DropTable("dbo.Proizvodi");
            DropTable("dbo.ProizvodiNaAkciji");
            DropTable("dbo.Akcije");
        }
    }
}
