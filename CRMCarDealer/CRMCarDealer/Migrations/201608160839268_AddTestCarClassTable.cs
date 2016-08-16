namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestCarClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestCars",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        ProductDetailsChasisSeries = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductDetails", t => t.ProductDetailsChasisSeries, cascadeDelete: true)
                .Index(t => t.ProductDetailsChasisSeries);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TestCars", "ProductDetailsChasisSeries", "dbo.ProductDetails");
            DropIndex("dbo.TestCars", new[] { "ProductDetailsChasisSeries" });
            DropTable("dbo.TestCars");
        }
    }
}
