namespace AteaPackageManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atea : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surename = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Screenshots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Image = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Films", "Description", c => c.String());
            AddColumn("dbo.Films", "Length", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "Length");
            DropColumn("dbo.Films", "Description");
            DropTable("dbo.Screenshots");
            DropTable("dbo.Producers");
        }
    }
}
