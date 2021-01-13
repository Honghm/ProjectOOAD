using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Data.Entities
{
   public class Bill
    {
        public string IDBill { get; set; }
        public string ServiceName { get; set; }
        public string DateCreated { get; set; }
        public string ServiceMachine { get; set; }

        public decimal TotalMoney { get; set; }

        public string CurrentAccountID { get; set; }
        public Account CurrentAccount { get; set; }

        public string CurrentSupplierID { get; set; }
        public Supplier CurrentSupplier { get; set; }
    }
}
