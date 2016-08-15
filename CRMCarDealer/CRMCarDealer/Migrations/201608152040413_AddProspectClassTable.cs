namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProspectClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prospects",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                        Details = c.String(),
                        ContactId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prospects", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Prospects", new[] { "ContactId" });
            DropTable("dbo.Prospects");
        }
    }
}
