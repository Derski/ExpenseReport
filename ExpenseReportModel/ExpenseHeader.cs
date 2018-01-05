using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReportModel
{
    public class ExpenseHeader
    {
        public int Id { get; set; }
        public DateTime SubmittalDate { get; set; }
        public DateTime PayDate { get; set; }

        public string Manager { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        public ICollection<ExpenseDetail> ExpenseDetails { get; set; }
    }
}
