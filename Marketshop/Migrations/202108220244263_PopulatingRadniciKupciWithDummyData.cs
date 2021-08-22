namespace Marketshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingRadniciKupciWithDummyData : DbMigration
    {
        public override void Up()
        {
            //Insertovanje radnih mesta
            Sql("INSERT INTO RadnaMesta(Pozicija) VALUES ('Regionalni Menadžer'),('Menadžer Prodavnice'),('Prodavac'),('Cistač'),('IT Administrator'),('Podrška')");
            //Insertovanje prodavnica
            Sql("INSERT INTO Prodavnice(Adresa,GradId) VALUES ('Pariska 9',1),('Filipa Kljajića 38',1), ('Fruškogorska 26',2),('Bulevar kralja Petara I 55-59',2),('Cara Lazara 189',2)");
            //Insertovanje radnika
            Sql("INSERT INTO Radnici(Ime,Prezime) VALUES ('Nemanja','Jović'),('Anđela','Stanković'),('Boško','Obradović'),('Milana','Kosanđić')");
            
        }
        
        public override void Down()
        {
            //Brisanje radnih mesta
            Sql("DELETE FROM RadnaMesta");
            //Brisanje svih prodavnica
            Sql("DELETE FROM Prodavnice");
            //Brisanje svih radnika
            Sql("DELETE FROM Radnik");
        }
    }
}
