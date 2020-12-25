namespace MultiCardSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Completeddb01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        IDSupplier = c.String(nullable: false, maxLength: 128),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.IDSupplier);
            
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        IDCustomer = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Dob = c.String(nullable: false, maxLength: 100),
                        CMND = c.String(nullable: false, maxLength: 11),
                        PhoneNumber = c.String(maxLength: 10),
                        Address = c.String(maxLength: 100),
                        Account_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDCustomer)
                .ForeignKey("dbo.Card", t => t.IDCustomer)
                .ForeignKey("dbo.Account", t => t.Account_ID)
                .Index(t => t.IDCustomer)
                .Index(t => t.Account_ID);
            
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
            
            AddColumn("dbo.Bill", "CurrentSupplierID", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Bill", "Report_ReportID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Bill", "CurrentSupplierID");
            CreateIndex("dbo.Bill", "Report_ReportID");
            AddForeignKey("dbo.Bill", "CurrentSupplierID", "dbo.Supplier", "IDSupplier", cascadeDelete: true);
            AddForeignKey("dbo.Bill", "Report_ReportID", "dbo.Report", "ReportID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customer", "Account_ID", "dbo.Account");
            DropForeignKey("dbo.Customer", "IDCustomer", "dbo.Card");
            DropForeignKey("dbo.Bill", "Report_ReportID", "dbo.Report");
            DropForeignKey("dbo.Report", "CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Bill", "CurrentSupplierID", "dbo.Supplier");
            DropIndex("dbo.Report", new[] { "CustomerID" });
            DropIndex("dbo.Customer", new[] { "Account_ID" });
            DropIndex("dbo.Customer", new[] { "IDCustomer" });
            DropIndex("dbo.Bill", new[] { "Report_ReportID" });
            DropIndex("dbo.Bill", new[] { "CurrentSupplierID" });
            DropColumn("dbo.Bill", "Report_ReportID");
            DropColumn("dbo.Bill", "CurrentSupplierID");
            DropTable("dbo.Report");
            DropTable("dbo.Customer");
            DropTable("dbo.Supplier");
        }
    }
}
