namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerReminderClassTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        UserId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Reminders",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SalesmanId = c.Byte(nullable: false),
                        CustomerId = c.Byte(nullable: false),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Salesmen", t => t.SalesmanId, cascadeDelete: false)
                .Index(t => t.SalesmanId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reminders", "SalesmanId", "dbo.Salesmen");
            DropForeignKey("dbo.Reminders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "UserId", "dbo.Users");
            DropIndex("dbo.Reminders", new[] { "CustomerId" });
            DropIndex("dbo.Reminders", new[] { "SalesmanId" });
            DropIndex("dbo.Customers", new[] { "UserId" });
            DropTable("dbo.Reminders");
            DropTable("dbo.Customers");
        }
    }
}
