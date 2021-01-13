using MultiCardSystem.Data.Entities;
using MultiCardSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Services
{
   public class BillService
    {
        private readonly IBillRepository _BillRepository;
        public BillService()
        {
            _BillRepository = new BillRepository(new Data.EF.MultiCardDbContext());
        }
        public BillService(IBillRepository billRepository)
        {
            _BillRepository = billRepository;
        }
        public async Task<bool> Delete(string id)
        {
            return await _BillRepository.Delete(id);
        }
        public List<Bill> GetAllBills()
        {
            return _BillRepository.GetAllBills();
        }

        public async Task<Bill> GetBillById(string id)
        {
            return await _BillRepository.GetBillById(id);
        }
        public async Task<bool> Insert(Bill request)
        {
            return await _BillRepository.Insert(request);
        }
        public async Task<bool> Update(Bill request)
        {
            return await _BillRepository.Update(request);
        }
    }
}
