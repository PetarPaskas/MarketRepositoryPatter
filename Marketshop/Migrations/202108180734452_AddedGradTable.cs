namespace Marketshop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedGradTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gradovi",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Prodavnice", "GradId", c => c.Int(nullable: false));
            CreateIndex("dbo.Prodavnice", "GradId");
            AddForeignKey("dbo.Prodavnice", "GradId", "dbo.Gradovi", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prodavnice", "GradId", "dbo.Gradovi");
            DropIndex("dbo.Prodavnice", new[] { "GradId" });
            DropColumn("dbo.Prodavnice", "GradId");
            DropTable("dbo.Gradovi");
        }
    }
}
