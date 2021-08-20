namespace Marketshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingDatabaseInfoInComments : DbMigration
    {
        public override void Up()
        {
            //Insertovanje gradova
            Sql("INSERT INTO Gradovi(Naziv) VALUES ('Sombor'),('Novi Sad')");
            //Insertovanje kategorija proizvoda
            Sql("INSERT INTO Kategorije VALUES ('Voće'),('Povrće'),('Testenine'),('Ulje'),('Jogurt'),('Mleko'),('Sir'),('Sveže meso'),('Sveža riba')");
            //Insertovanje proizvodjaca
            Sql(@"INSERT INTO Proizvodjaci(Naziv) VALUES ('Neobjavljeno'),
                                                        ('Dijamant'),
                                                        ('Carapelli'),
                                                        ('Monini'),
                                                        ('Beyond'),
                                                        ('Barilla'),
                                                        ('Danubius'),
                                                        ('Dukat'),
                                                        ('Imlek'),
                                                        ('President'),
                                                        ('Biser')");
            

        }
        
        public override void Down()
        {
            //Brisanje gradova
            Sql("DELETE FROM Gradovi WHERE Naziv = 'Sombor' OR Naziv = 'Novi Sad'");
            //Brisanje kategorija proizvoda
            Sql("DELETE FROM Kategorije WHERE Naziv = 'Voće' OR Naziv = 'Ulje' OR Naziv = 'Testenine' OR Naziv = 'Povrće' OR Naziv = 'Jogurt' OR Naziv = 'Mleko' OR Naziv = 'Sir' OR Naziv = 'Sveže meso' OR Naziv = 'Sveža riba'");
            //Brisanje proizvodjaca
            Sql("DELETE FROM Proizvodjaci");
            
            
        }
    }
}
