using MultiCardSystem.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Data.Entities
{
    public class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }
        public int RoleId { get; set; }
        public RoleName RoleName { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
