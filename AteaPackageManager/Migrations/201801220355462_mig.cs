namespace AteaPackageManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "ProducerId", c => c.Int());
            AlterColumn("dbo.Films", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Films", "Length", c => c.DateTime());
            CreateIndex("dbo.Films", "ProducerId");
            AddForeignKey("dbo.Films", "ProducerId", "dbo.Producers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "ProducerId", "dbo.Producers");
            DropIndex("dbo.Films", new[] { "ProducerId" });
            AlterColumn("dbo.Films", "Length", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Films", "Name", c => c.String());
            DropColumn("dbo.Films", "ProducerId");
        }
    }
}
