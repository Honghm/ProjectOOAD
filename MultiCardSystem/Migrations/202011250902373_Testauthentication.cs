namespace MultiCardSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testauthentication : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.AccountRoles",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.ID })
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Account", t => t.ID, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.ID);
            
            AddColumn("dbo.Account", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountRoles", "ID", "dbo.Account");
            DropForeignKey("dbo.AccountRoles", "RoleId", "dbo.Role");
            DropIndex("dbo.AccountRoles", new[] { "ID" });
            DropIndex("dbo.AccountRoles", new[] { "RoleId" });
            DropColumn("dbo.Account", "Status");
            DropTable("dbo.AccountRoles");
            DropTable("dbo.Role");
        }
    }
}
