using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReportModel
{
    public class MileageHeader
    {
        public int Id { get; set; }
        public string Driver { get; set; }
        public DateTime SubmittalDate { get; set; }
        public string Manager { get; set; }//approver which must sign -> approval workflow

        public DateTime PayDate { get; set; }

        public ICollection<MileageDetailEntry> MileageDetails{ get; set; }
    }
}
