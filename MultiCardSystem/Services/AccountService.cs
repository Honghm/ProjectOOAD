using MultiCardSystem.Data.Entities;
using MultiCardSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Services
{
    public class AccountService
    {
        private readonly IAccountRepository _AccountService;
        public AccountService (IAccountRepository accountRepository)
        {
            _AccountService = accountRepository;
        }

        public void Delete(Account obj)
        {
            _AccountService.Delete(obj.ID);
        }
    }
}
