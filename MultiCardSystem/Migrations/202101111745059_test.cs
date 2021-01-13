namespace MultiCardSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        IDAccount = c.String(nullable: false, maxLength: 13),
                        UserName = c.String(nullable: false, maxLength: 50),
                        PassWord = c.String(nullable: false, maxLength: 50),
                        Money = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        RoleName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customer", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        IDBill = c.String(nullable: false, maxLength: 128),
                        ServiceName = c.String(nullable: false, maxLength: 100),
                        DateCreated = c.String(nullable: false, maxLength: 100),
                        ServiceMachine = c.String(nullable: false, maxLength: 100),
                        TotalMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentAccountID = c.String(nullable: false, maxLength: 128),
                        CurrentSupplierID = c.String(nullable: false, maxLength: 128),
                        Report_ReportID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IDBill)
                .ForeignKey("dbo.Account", t => t.CurrentAccountID, cascadeDelete: true)
                .ForeignKey("dbo.Supplier", t => t.CurrentSupplierID, cascadeDelete: true)
                .ForeignKey("dbo.Report", t => t.Report_ReportID)
                .Index(t => t.CurrentAccountID)
                .Index(t => t.CurrentSupplierID)
                .Index(t => t.Report_ReportID);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        IDSupplier = c.String(nullable: false, maxLength: 128),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.IDSupplier);
            
            CreateTable(
                "dbo.Card",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        IDCard = c.String(nullable: false, maxLength: 16),
                        DateCreated = c.String(nullable: false, maxLength: 50),
                        PINCode = c.String(nullable: false, maxLength: 6),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Account", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Dob = c.String(nullable: false, maxLength: 100),
                        CMND = c.String(nullable: false, maxLength: 11),
                        PhoneNumber = c.String(maxLength: 10),
                        Address = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Report",
                c => new
                    {
                        ReportID = c.String(nullable: false, maxLength: 128),
                        DateReport = c.String(nullable: false, maxLength: 100),
                        Note = c.String(nullable: false, maxLength: 200),
                        CustomerID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReportID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bill", "Report_ReportID", "dbo.Report");
            DropForeignKey("dbo.Report", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Account", "ID", "dbo.Customer");
            DropForeignKey("dbo.Card", "ID", "dbo.Account");
            DropForeignKey("dbo.Bill", "CurrentSupplierID", "dbo.Supplier");
            DropForeignKey("dbo.Bill", "CurrentAccountID", "dbo.Account");
            DropIndex("dbo.Report", new[] { "CustomerID" });
            DropIndex("dbo.Card", new[] { "ID" });
            DropIndex("dbo.Bill", new[] { "Report_ReportID" });
            DropIndex("dbo.Bill", new[] { "CurrentSupplierID" });
            DropIndex("dbo.Bill", new[] { "CurrentAccountID" });
            DropIndex("dbo.Account", new[] { "ID" });
            DropTable("dbo.Report");
            DropTable("dbo.Customer");
            DropTable("dbo.Card");
            DropTable("dbo.Supplier");
            DropTable("dbo.Bill");
            DropTable("dbo.Account");
        }
    }
}
