using ExpenseReportModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReportDataAccess
{
    public class ExpenseReportDbContext:DbContext
    {
        public ExpenseReportDbContext():base("ExpenseReportDb")
        {

        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<ExpenseCode> ExpenseCodes { get; set; }
        public DbSet<ExpenseDetail> ExpenseDetails { get; set; }
        public DbSet<ExpenseHeader> ExpenseHeader { get; set; }
        public DbSet<MileageDetailEntry> MileageDetailEntry { get; set; }
        public DbSet<MileageHeader> MileageHeader { get; set; }
        public DbSet<ProjectCode> ProjectCode { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
