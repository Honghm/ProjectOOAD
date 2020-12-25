using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Data.Entities
{
   public class Report
    {
        public string ReportID { get; set; }
        public string DateReport { get; set; }
        public string Note { get; set; }
        public List<Bill> ListBills { get; set; }
        public string CustomerID { get; set; }
        public Customer CurrentCustomer { get; set; }
    }
}
