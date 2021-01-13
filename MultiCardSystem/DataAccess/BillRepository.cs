using MultiCardSystem.Data.EF;
using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
    public class BillRepository : IBillRepository
    {
        private readonly MultiCardDbContext _context;
        public BillRepository()
        {
            _context = new MultiCardDbContext();
        }
        public BillRepository(MultiCardDbContext Context)
        {
            _context = Context;
        }
        public async Task<bool> Delete(string id)
        {
            var bill = await _context.Bills.FindAsync(id);
            if (bill == null) return false;
            _context.Bills.Remove(bill);
            return await _context.SaveChangesAsync() > 0;
        }

        public List<Bill> GetAllBills(string id)
        {
            //var query = from c in _context.Bills
            //            select c;
            //var data = query
            //    .Select(x => new Bill()
            //    {
            //        IDBill = x.IDBill,
            //        ServiceName = x.ServiceName,
            //        DateCreated = x.DateCreated,
            //        ServiceMachine = x.ServiceMachine,
            //        TotalMoney = x.TotalMoney,
            //    }).ToList();
            //return data;
            List<Bill> lst = _context.Bills.ToList();
            List<Bill> lst1 = new List<Bill>();
            foreach(Bill b in lst)
            {
                if(b.CurrentAccountID == id)
                {
                    lst1.Add(b);
                }    
            }
            return lst1;
        }

        public async Task<Bill> GetBillById(string id)
        {
            var bill = await _context.Bills.FindAsync(id);         
            if (bill == null) return null;
            return bill;
        }

        public async Task<bool> Insert(Bill request)
        {
            var bill = new Bill()
            {
                IDBill = request.IDBill,
                ServiceName = request.ServiceName,
                DateCreated = request.DateCreated,
                ServiceMachine = request.ServiceMachine,
                statusBill = request.statusBill,
                TotalMoney = request.TotalMoney,
                CurrentAccountID = request.CurrentAccountID,
                CurrentSupplierID = request.CurrentSupplierID,

            };
            _context.Bills.Add(bill);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> ThanhToan(string id)
        {
            var bill = await _context.Bills.FindAsync(id);
            var account = await _context.accounts.FindAsync(bill.CurrentAccountID);
            if (bill == null) return false;
            if(bill.statusBill == Enum.StatusBill.unpaid)
            {
                account.Money -= bill.TotalMoney;
                bill.statusBill = Enum.StatusBill.paid;
                return await _context.SaveChangesAsync() > 0;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Update(Bill request)
        {
            var bill = await _context.Bills.FindAsync(request.IDBill);
            if (bill == null) return false;
            if (!string.IsNullOrEmpty(request.ServiceMachine))
                bill.ServiceMachine = request.ServiceMachine;
            if (!string.IsNullOrEmpty(request.ServiceName))
                bill.ServiceName = request.ServiceName;
            if (!string.IsNullOrEmpty(request.TotalMoney.ToString()))
                bill.TotalMoney = request.TotalMoney;
            if (!string.IsNullOrEmpty(request.DateCreated))
                bill.DateCreated = request.DateCreated;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
