namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalesmanClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salesmen",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        UserId = c.Byte(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salesmen", "UserId", "dbo.Users");
            DropIndex("dbo.Salesmen", new[] { "UserId" });
            DropTable("dbo.Salesmen");
        }
    }
}
