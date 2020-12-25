using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
    public interface IAccountRepository 
    {
        Task<bool> Delete(int id);
       


        

    }
}
