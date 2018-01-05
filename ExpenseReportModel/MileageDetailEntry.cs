using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReportModel
{
    public class MileageDetailEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public string TripDescription { get; set; }

        public int Mileage { get; set; }

        public double Amount { get; set; }

        public  MileageHeader MileageHeader { get; set; }

        public int MileageHeaderId { get; set; }

    }
}
