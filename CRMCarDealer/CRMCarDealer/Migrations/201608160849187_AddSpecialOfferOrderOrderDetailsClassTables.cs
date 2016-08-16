namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSpecialOfferOrderOrderDetailsClassTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        CustomerId = c.Byte(nullable: false),
                        SpecialOfferId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.SpecialOffers", t => t.SpecialOfferId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.SpecialOfferId);
            
            CreateTable(
                "dbo.SpecialOffers",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Discount = c.Single(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        ProductId = c.Byte(nullable: false),
                        OrderId = c.Byte(nullable: false),
                        Quantity = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "SpecialOfferId", "dbo.SpecialOffers");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "SpecialOfferId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.OrderDetails");
            DropTable("dbo.SpecialOffers");
            DropTable("dbo.Orders");
        }
    }
}
