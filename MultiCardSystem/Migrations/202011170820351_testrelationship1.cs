namespace MultiCardSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testrelationship1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        IDBill = c.String(nullable: false, maxLength: 128),
                        ServiceName = c.String(nullable: false, maxLength: 100),
                        DateCreated = c.String(nullable: false, maxLength: 100),
                        ServiceMachine = c.String(nullable: false, maxLength: 100),
                        TotalMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentAccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDBill)
                .ForeignKey("dbo.Account", t => t.CurrentAccountID, cascadeDelete: true)
                .Index(t => t.CurrentAccountID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bill", "CurrentAccountID", "dbo.Account");
            DropIndex("dbo.Bill", new[] { "CurrentAccountID" });
            DropTable("dbo.Bill");
        }
    }
}
