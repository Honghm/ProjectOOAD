using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
   public interface IBillRepository
    {
        Task<Bill> GetBillById(string id);
        List<Bill> GetAllBills(string id);
        Task<bool> Insert(Bill request);
        Task<bool> Delete(string id);
        Task<bool> Update(Bill request);
        Task<bool> ThanhToan(string id);
    }
}
