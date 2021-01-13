namespace MultiCardSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbill : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bill", "Report_ReportID", "dbo.Report");
            DropIndex("dbo.Bill", new[] { "Report_ReportID" });
            RenameColumn(table: "dbo.Bill", name: "Report_ReportID", newName: "CurrentReportID");
            AddColumn("dbo.Bill", "statusBill", c => c.Int(nullable: false));
            AlterColumn("dbo.Bill", "CurrentReportID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Bill", "CurrentReportID");
            AddForeignKey("dbo.Bill", "CurrentReportID", "dbo.Report", "ReportID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bill", "CurrentReportID", "dbo.Report");
            DropIndex("dbo.Bill", new[] { "CurrentReportID" });
            AlterColumn("dbo.Bill", "CurrentReportID", c => c.String(maxLength: 128));
            DropColumn("dbo.Bill", "statusBill");
            RenameColumn(table: "dbo.Bill", name: "CurrentReportID", newName: "Report_ReportID");
            CreateIndex("dbo.Bill", "Report_ReportID");
            AddForeignKey("dbo.Bill", "Report_ReportID", "dbo.Report", "ReportID");
        }
    }
}
