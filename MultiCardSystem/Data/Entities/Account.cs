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
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public decimal Money { get; set; }

        public Status Status { get; set; }

        public virtual Card Card { get; set; }

        public ICollection<Bill> Bills { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

    }
}
