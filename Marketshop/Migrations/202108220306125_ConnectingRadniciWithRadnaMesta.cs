namespace Marketshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectingRadniciWithRadnaMesta : DbMigration
    {
        public override void Up()
        {
            //RadnikRadnoMesto
            Sql("INSERT INTO RadnaMestaRadnika(RadnikId,RadnoMestoId,ProdavnicaId) VALUES (1,3,1),(2,3,1),(3,4,1),(4,2,1)");
            //Ugovori
            Sql(@"INSERT INTO Ugovori(RadnikId,DatumPocetkaRada,DuzinaTrajanjaUgovora,Plata)
                                 VALUES (1,GETDATE(),6,37000.00),
                                        (2,GETDATE(),6,37000.00),
                                        (3,GETDATE(),6,31000.00),
                                        (4,GETDATE(),6,58000.00)");
        }
        
        public override void Down()
        {
            //Brisni RadnaMestaRadnika
            Sql("DELETE FROM RadnaMestaRadnika");
            //Brisni ugovore
            Sql("DELETE FROM Ugovori");
        }
    }
}
