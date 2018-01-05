using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReportModel
{
    public class ExpenseDetail
    {
        public int Id { get; set; }

        public ExpenseHeader ExpenseHeader { get; set; }
        public int ExpenseHeaderId { get; set; }

        public ExpenseCode ExpenseCode { get; set;}
        public int ExpenseCodeId { get; set; }

        public DateTime Date { get; set; }
        public string PaidTo { get; set; }
        public string Reason { get; set; }

        public double TotalAmount { get; set; }
        public double TipOrNonGST { get; set; }
        public bool IsGST { get; set; }


    }
}
