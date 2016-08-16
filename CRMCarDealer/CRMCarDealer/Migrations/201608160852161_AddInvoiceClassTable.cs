namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInvoiceClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        OrderId = c.Byte(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Series = c.String(),
                        Number = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoices", "OrderId", "dbo.Orders");
            DropIndex("dbo.Invoices", new[] { "OrderId" });
            DropTable("dbo.Invoices");
        }
    }
}
