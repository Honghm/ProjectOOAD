namespace MultiCardSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testrelationship : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Accounts", newName: "Account");
            CreateTable(
                "dbo.Card",
                c => new
                    {
                        IDCard = c.String(nullable: false, maxLength: 128),
                        DateCreated = c.String(nullable: false, maxLength: 50),
                        PINCode = c.String(nullable: false, maxLength: 6),
                        Account_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDCard)
                .ForeignKey("dbo.Account", t => t.Account_ID)
                .Index(t => t.Account_ID);
            
            AlterColumn("dbo.Account", "PassWord", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Card", "Account_ID", "dbo.Account");
            DropIndex("dbo.Card", new[] { "Account_ID" });
            AlterColumn("dbo.Account", "PassWord", c => c.String());
            DropTable("dbo.Card");
            RenameTable(name: "dbo.Account", newName: "Accounts");
        }
    }
}
