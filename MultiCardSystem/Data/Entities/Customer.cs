using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Data.Entities
{
   public class Customer
    {
        // public string IDCard { get; set; }
        public string ID { get; set; }
       // public string IDCustomer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }

        public string CMND { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public virtual Account Accounts { get; set; }
       // public virtual Card Cards { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}
