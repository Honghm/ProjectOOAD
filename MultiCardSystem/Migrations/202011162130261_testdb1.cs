namespace MultiCardSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testdb1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Money", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Accounts", "UserName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "UserName", c => c.String());
            DropColumn("dbo.Accounts", "Money");
        }
    }
}
