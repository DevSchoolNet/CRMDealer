namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDriveTestClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DriveTests",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        ProspectId = c.Byte(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        SalesmanId = c.Byte(nullable: false),
                        TestCarId = c.Byte(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Prospects", t => t.ProspectId, cascadeDelete: true)
                .ForeignKey("dbo.Salesmen", t => t.SalesmanId, cascadeDelete: false)
                .ForeignKey("dbo.TestCars", t => t.TestCarId, cascadeDelete: true)
                .Index(t => t.ProspectId)
                .Index(t => t.SalesmanId)
                .Index(t => t.TestCarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DriveTests", "TestCarId", "dbo.TestCars");
            DropForeignKey("dbo.DriveTests", "SalesmanId", "dbo.Salesmen");
            DropForeignKey("dbo.DriveTests", "ProspectId", "dbo.Prospects");
            DropIndex("dbo.DriveTests", new[] { "TestCarId" });
            DropIndex("dbo.DriveTests", new[] { "SalesmanId" });
            DropIndex("dbo.DriveTests", new[] { "ProspectId" });
            DropTable("dbo.DriveTests");
        }
    }
}
