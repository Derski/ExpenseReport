namespace ExpenseReportDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpenseCode",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpenseDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseHeaderId = c.Int(nullable: false),
                        ExpenseCodeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        PaidTo = c.String(),
                        Reason = c.String(),
                        TotalAmount = c.Double(nullable: false),
                        TipOrNonGST = c.Double(nullable: false),
                        IsGST = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCode", t => t.ExpenseCodeId, cascadeDelete: true)
                .ForeignKey("dbo.ExpenseHeader", t => t.ExpenseHeaderId, cascadeDelete: true)
                .Index(t => t.ExpenseHeaderId)
                .Index(t => t.ExpenseCodeId);
            
            CreateTable(
                "dbo.ExpenseHeader",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubmittalDate = c.DateTime(nullable: false),
                        PayDate = c.DateTime(nullable: false),
                        Manager = c.String(),
                        EmployeeId = c.Int(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        Employee_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.Employee_Id)
                .Index(t => t.DepartmentId)
                .Index(t => t.Employee_Id);
            
            CreateTable(
                "dbo.MileageDetailEntry",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Client = c.String(),
                        TripDescription = c.String(),
                        Mileage = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        MileageHeaderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MileageHeader", t => t.MileageHeaderId, cascadeDelete: true)
                .Index(t => t.MileageHeaderId);
            
            CreateTable(
                "dbo.MileageHeader",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Driver = c.String(),
                        SubmittalDate = c.DateTime(nullable: false),
                        Manager = c.String(),
                        PayDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectCode",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MileageDetailEntry", "MileageHeaderId", "dbo.MileageHeader");
            DropForeignKey("dbo.ExpenseDetail", "ExpenseHeaderId", "dbo.ExpenseHeader");
            DropForeignKey("dbo.ExpenseHeader", "Employee_Id", "dbo.Employee");
            DropForeignKey("dbo.ExpenseHeader", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.ExpenseDetail", "ExpenseCodeId", "dbo.ExpenseCode");
            DropIndex("dbo.MileageDetailEntry", new[] { "MileageHeaderId" });
            DropIndex("dbo.ExpenseHeader", new[] { "Employee_Id" });
            DropIndex("dbo.ExpenseHeader", new[] { "DepartmentId" });
            DropIndex("dbo.ExpenseDetail", new[] { "ExpenseCodeId" });
            DropIndex("dbo.ExpenseDetail", new[] { "ExpenseHeaderId" });
            DropTable("dbo.ProjectCode");
            DropTable("dbo.MileageHeader");
            DropTable("dbo.MileageDetailEntry");
            DropTable("dbo.ExpenseHeader");
            DropTable("dbo.ExpenseDetail");
            DropTable("dbo.ExpenseCode");
            DropTable("dbo.Employee");
            DropTable("dbo.Department");
        }
    }
}
