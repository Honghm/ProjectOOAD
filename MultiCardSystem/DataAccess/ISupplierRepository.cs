using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
   public interface ISupplierRepository
    {
        Task<Supplier> GetSupplierById(string id);
        List<Supplier> GetAllSuppliers();
        Task<bool> Insert(Supplier request);
        Task<bool> Delete(string id);
        Task<bool> Update(Supplier request);
    }
}
