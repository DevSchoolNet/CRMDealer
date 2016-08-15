namespace CRMCarDealer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserClassTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        UserName = c.String(),
                        PassWord = c.String(),
                        ContactId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Users", new[] { "ContactId" });
            DropTable("dbo.Users");
        }
    }
}
