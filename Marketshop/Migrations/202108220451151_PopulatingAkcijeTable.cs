namespace Marketshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingAkcijeTable : DbMigration
    {
        public override void Up()
        {
            //Insertovanje akcija; DuzinaTrajanja u danima
            Sql(@"INSERT INTO Akcije(Popust,DuzinaTrajanja,Opis)
                             VALUES (5,2,'Vikend Akcija'),
                                    (10,2,'Vikend Akcija'),
                                    (25,7,'Letnje nedeljno sniženje'),
                                    (45,7,'Poslednji komadi'),
                                    (60,7,'Pred istek roka trajanja')");
        }
        
        public override void Down()
        {
            //Brisanje akcija
            Sql("DELETE FROM Akcija");
        }
    }
}
