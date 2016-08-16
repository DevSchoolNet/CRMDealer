namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        QuantityForSale = c.Int(nullable: false),
                        QuantityForTest = c.Int(nullable: false),
                        Model = c.String(),
                        EngineCapacity = c.Single(nullable: false),
                        Price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
