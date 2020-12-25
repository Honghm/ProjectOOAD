using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Data.Entities
{
    public class Card
    {
        public string IDCard { get; set; }
        public string DateCreated { get; set; }
        public string PINCode { get; set; }

        //public int IDAccount { get; set; }

        public virtual Account Account { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
