namespace ExpenseReportDataAccess.Migrations
{
    using ExpenseReportModel;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ExpenseReportDataAccess.ExpenseReportDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ExpenseReportDataAccess.ExpenseReportDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Departments.AddOrUpdate(
                d => d.Code,
                new Department { Code = "ADMIN", Name = "ADMIN" },
                new Department { Code = "CAN - OPS", Name = "CAN - OPS" },
                new Department { Code = "ENGINEERING", Name = "ENGINEERING" },
                new Department { Code = "IT", Name = "IT" },
                new Department { Code = "MFG", Name = "MFG" },
                new Department { Code = "OPS DL", Name = "OPS DL" },
                new Department { Code = "REL", Name = "REL" },
                new Department { Code = "SALES", Name = "SALES" },
                new Department { Code = "SC", Name = "SC" },
                new Department { Code = "US - OPS", Name = "US - OPS" }
                );

            context.Employees.AddOrUpdate(
                e => e.Id,
                new Employee { Id = "cderkowski", Name = "Chris Derkowski" },
                new Employee { Id = "jshelton", Name = "Josh Shelton" },
                new Employee { Id = "eramirez", Name = "Edward Ramirez" },
                new Employee { Id = "mmartin", Name = "Maxine Martin" },
                new Employee { Id = "smohr", Name = "Sarah Mohr" },
                new Employee { Id = "rbrisson", Name = "Robert Brisson" }
                );

            context.ExpenseCodes.AddOrUpdate(
                c => c.Code,
                new ExpenseCode { Code = "64100", Name= "Non Amortized Software" },
                new ExpenseCode { Code = "64200", Name = "Non Amortized Hardware" },
                new ExpenseCode { Code = "52500", Name = "Shipping" },
                new ExpenseCode { Code = "61100", Name = "Advertising" },
                new ExpenseCode { Code = "61200", Name = "Entertainment - Selling" },
                new ExpenseCode { Code = "61300", Name = "Travel - Taxi/Rental - Selling " },
                new ExpenseCode { Code = "61310", Name = "Travel - Hotel - Selling" },
                new ExpenseCode { Code = "61320", Name = "Travel - Airfare - Selling" }
                );

            context.ProjectCode.AddOrUpdate(
                pc => pc.Code,
                new ProjectCode { Code= "LAB", Name= "All Test " },
                new ProjectCode { Code = "DH TOOL", Name = "Downhole Tool" },
                new ProjectCode { Code = "EVOi", Name = "Evoi" },
                new ProjectCode { Code = "CHITS", Name = "CHITS Project" },
                new ProjectCode { Code = "SURFACE", Name = "Surface Equipment" },
                new ProjectCode { Code = "GAPSUB", Name = "Gap Sub Redesign" },
                new ProjectCode { Code = "OTHER", Name = "Other" }
                );


        }
    }
}
