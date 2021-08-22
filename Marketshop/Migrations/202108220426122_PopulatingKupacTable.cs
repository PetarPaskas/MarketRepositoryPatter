namespace Marketshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingKupacTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kupci", "GradId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kupci", "GradId");
            AddForeignKey("dbo.Kupci", "GradId", "dbo.Gradovi", "Id", cascadeDelete: true);

            //Insert 2 kupca
            Sql(@"INSERT INTO Kupci(GradId,Ime,Prezime,Adresa)
                                VALUES (1,'Petar','Petrović', 'Mite Popovića 38'),
                                        (2,'Marko','Marković', 'Bulevar Evrope 72a')");
        }
        
        public override void Down()
        {
            //Delete kupaca
            Sql("DELETE FROM Kupci");

            DropForeignKey("dbo.Kupci", "GradId", "dbo.Gradovi");
            DropIndex("dbo.Kupci", new[] { "GradId" });
            DropColumn("dbo.Kupci", "GradId");
        }
    }
}
