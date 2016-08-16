namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductDetailsClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ChasisSeries = c.Byte(nullable: false),
                        ProductId = c.Byte(nullable: false),
                        IsForSale = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ChasisSeries)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductDetails", new[] { "ProductId" });
            DropTable("dbo.ProductDetails");
        }
    }
}
