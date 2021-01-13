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
        Task<bool> Delete(string id);
        List<Account> GetAllAccounts();

        bool LoginAdmin(string userName, string passWord);
        bool LoginUser(string userName, string passWord);

        Task<bool> Insert(Account request);
        Task<bool> Update(Account request);

        Task<bool> RutTien(string id,string PIN,decimal money);
        Task<bool> ChuyenTien(string id, string ReceiveAccount, decimal money);

    }
}
