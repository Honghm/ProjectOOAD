using MultiCardSystem.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Data.Entities
{
    public class Account
    {
        public string ID { get; set; }
        public string IDAccount { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public decimal Money { get; set; }

        public Status Status { get; set; }
        public RoleName RoleName { get; set; }

        public virtual Card Cards { get; set; }

        public ICollection<Bill> Bills { get; set; }

        public virtual Customer Customers { get; set; }

        //public virtual ICollection<Role> Roles { get; set; }

    }
}
