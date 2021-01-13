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
        private readonly IAccountRepository _AccountRepository;
        public AccountService()
        {
            _AccountRepository = new AccountRepository(new Data.EF.MultiCardDbContext());
        }
        public AccountService (IAccountRepository accountRepository)
        {
            _AccountRepository = accountRepository;
        }

        public async Task<bool> Delete(string id)
        {
            return await _AccountRepository.Delete(id);
          
        }

        public List<Account> GetAllAccounts()
        {
            return _AccountRepository.GetAllAccounts();
        }
        public bool LoginAdmin(string userName, string passWord)
        {
            return _AccountRepository.LoginAdmin(userName, passWord);
        }
        public bool LoginUser(string userName, string passWord)
        {
            return _AccountRepository.LoginUser(userName, passWord);
        }
        public async Task<bool> Insert(Account request)
        {
            return await _AccountRepository.Insert(request);
        }
        public async Task<bool> RutTien(string id, string PIN, decimal money)
        {
            return await _AccountRepository.RutTien(id, PIN, money);
        }
        public async Task<bool> Update(Account request)
        {
            return await _AccountRepository.Update(request);
        }
        public async Task<bool> ChuyenTien(string id, string ReceiveAccount, decimal money)
        {
            return await _AccountRepository.ChuyenTien(id, ReceiveAccount, money);
        }
    }
}
