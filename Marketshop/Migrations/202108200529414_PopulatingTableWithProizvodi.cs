namespace Marketshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingTableWithProizvodi : DbMigration
    {
        public override void Up()
        {
            //Insertovanje proizvoda
            Sql(@"INSERT INTO Proizvodi(ProizvodjacId,KategorijaId,Naziv,Cena,Tezina,JedinicaTezine,Bodovi)
                         VALUES (1,1,'Banane',109.99,1, 2, 1), 
                                (1,1,'Grejp crveni',199.99,1,2,2),
                                (1,1,'Jabuke ajdared',99.99,1,2,1),
                                (1,1,'Limun',199.99,1,2,2),
                                (1,2,'Beli luk',349.99,1,2,4),
                                (1,2,'Brokoli',199.99,1,2,2),
                                (1,2,'Crni luk',79.99,1,2,1),
                                (1,2,'Krompir crveni',59.99,1,2,1),
                                (1,2,'Kupus mladi',79.99,1,2,1),
                                (1,2,'Krompir beli',49.99,1,2,1),
                                (2,4,'Suncokretovo ulje',169.99,1,4,2),
                                (2,4,'Suncokretovo ulje',893.99,5,4,9),
                                (3,4,'Maslinovo ulje ekstra devicansko',899.99,1,4,9),
                                (4,4,'Maslinovo ulje ekstra devicansko',782.99,500,3,8),
                                (5,4,'Kokosovo ulje',789.99,310,1,3),
                                (6,3,'Spaghetti n.3',119.99,500,1,1),
                                (6,3,'Spaghetti n.5',174.99,500,1,2),
                                (7,3,'Spaghetti',89.99,500,1,1),
                                (7,3,'Makaroni',72.99,400,1,1),
                                (8,5,'Jogurt',89.99,1,2,1),
                                (8,5,'Jogurt',129.99,1500,1,1),
                                (9,5,'Jogurt balans',99.99,1,2,1),
                                (9,5,'Jogurt balans',139.99,1500,1,1),
                                (9,6,'Mleko dugotrajno bez laktoze 1.5%',117.99,1500,1,1),
                                (9,6,'Mleko dugotrajno za kafu 3.8%',126.99,1,4,1),
                                (8,6,'Sveze mleko 2.8%',119.99,1500,3,1),
                                (8,6,'Sveze mleko 1.5%',122.99,1500,3,1),
                                (9,6,' Mleko dugotrajno moja kravica 2.8%',119.99,1500,3,1),
                                (10,7,'Somborska feta',139.99,250,1,1),
                                (10,7,'Somborska feta',239.99,500,1,2),
                                (11,7,'Mozzarella pizza',531.99,450,1,5),
                                (11,7,'Edamer 45%mm',799.00,1,2,8),
                                (10,7,'Gauda',799.00,1,2,8),
                                (11,7,'Kackavalj',1268.99,1,2,13),
                                (1,8,'Jagnjetina',699.99,1,2,7),
                                (1,8,'Juneća rebra',579.99,1,2,6),
                                (1,8,'Juneći but bez kostiju',679.99,1,2,7),
                                (1,8,'Ćevapi',439.99,1,2,4),
                                (1,8,'Pileće grudi',399.99,1,2,4),
                                (1,8,'Svinjetina',399.99,1,2,4),
                                (1,9,'Brancin',1099.99,1,2,11),
                                (1,9,'Losos filet',1899.99,1,2,19),
                                (1,9,'Šaran',329.99,1,2,3),
                                (1,9,'Pastrmka kaliformijska',429.99,1,2,4)");
        }
        
        public override void Down()
        {
            //Brisanje proizvoda
            Sql("DELETE FROM Proizvodi");
        }
    }
}
