using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using MultiCardSystem.Data.EF;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
    public class AccountRepository : IAccountRepository
    {
        private readonly MultiCardDbContext _context;
        public AccountRepository()
        {
            _context = new MultiCardDbContext();
        }
        public AccountRepository(MultiCardDbContext Context)
        {
            _context = Context;
        }

        public async Task<bool> ChuyenTien(string id, string ReceiveAccount, decimal money)
        {
            
            var account = await _context.accounts.FindAsync(id);
            List<Account> lst = _context.accounts.ToList();
            bool flag = false;

            foreach (Account a in lst)
            {
                if (a.IDAccount == ReceiveAccount)
                {
                    account.Money -= money;
                    a.Money += money;
                    flag = true;
                }
            }
            if (flag)
            {
                return await _context.SaveChangesAsync() > 0; 
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Delete(string id)
        {
            var account = await _context.accounts.FindAsync(id);
            
            if(account == null)
            {
                return false;
            }
             _context.accounts.Remove(account);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<Account> GetAccountByID(string id)
        {
            var account = await _context.accounts.FindAsync(id);
            if (account == null) return null;
            return account;
        }

        public List<Account> GetAllAccounts()
        {
            return _context.accounts.ToList();
        }

        public async Task<bool> Insert(Account request)
        {
            var account = new Account()
            {
                ID = request.ID,
                IDAccount = request.IDAccount,
                UserName = request.UserName,
                PassWord = request.PassWord,
                Money = request.Money,
                Status = request.Status,
                RoleName = request.RoleName,

            };
            _context.accounts.Add(account);
            return await _context.SaveChangesAsync() > 0;
        }

        public bool LoginAdmin(string userName, string passWord)
        {
            List<Account> list = _context.accounts.ToList();
            foreach (var a in list)
            {
                if (a.UserName == userName && a.PassWord == passWord)
                {
                    if (a.Status == 0 && a.RoleName == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool LoginUser(string userName, string passWord)
        {
            List<Account> list = _context.accounts.ToList();
            foreach (var a in list)
            {
                if (a.UserName == userName && a.PassWord == passWord)
                {
                    if (a.Status == 0 && a.RoleName != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public async Task<bool> RutTien(string id,string PIN,decimal money)
        {
            var account = await _context.accounts.FindAsync(id);
            if(account.Cards.PINCode == PIN)
            {
                account.Money = account.Money - money;
            }
            else
            {
                return false;
            }
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(Account request)
        {
            var account = await _context.accounts.FindAsync(request.ID);
            if (account == null) return false;
            if (!string.IsNullOrEmpty(request.IDAccount))
                account.IDAccount = request.IDAccount;
            if (!string.IsNullOrEmpty(request.UserName))
                account.UserName = request.UserName;
            if (!string.IsNullOrEmpty(request.PassWord))
                account.PassWord = request.PassWord;
            return await _context.SaveChangesAsync() > 0;
        }
        //public async Task<bool> Insert(Account request)
        //{
        //    var account = new Account()
        //    {
        //        ID = request.ID,
        //        UserName = request.UserName,
        //        PassWord = request.PassWord,
        //        Money = request.Money,
        //        Status = request.Status,
        //        RoleName = request.RoleName,

        //    };
        //    _context.accounts.Add(account);
        //    return await _context.SaveChangesAsync() > 0;

        //}

        //public bool LoginAdmin(string userName, string passWord)
        //{
        //    List<Account> list = _context.accounts.ToList();
        //    foreach (var a in list)
        //    {
        //        if (a.UserName == userName && a.PassWord == passWord)
        //        {
        //            if (a.Status == 0 && a.RoleName == 0)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return false;

        //}

        //public bool LoginUser(string userName, string passWord)
        //{
        //    List<Account> list = _context.accounts.ToList();
        //    foreach (var a in list)
        //    {
        //        if (a.UserName == userName && a.PassWord == passWord)
        //        {
        //            if (a.Status == 0 && a.RoleName != 0)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return false;

        //}

        //public Task<bool> Update(Account request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
