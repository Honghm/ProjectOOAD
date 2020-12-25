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
        public AccountRepository(MultiCardDbContext Context)
        {
            _context = Context;
        }
        public async Task<bool> Delete(int id)
        {
            var account = await _context.accounts.FindAsync(id);
            if(account == null)
            {
                return false;
            }
            var result = _context.accounts.Remove(account);
            return await _context.SaveChangesAsync() > 0;

        }
    }
}
