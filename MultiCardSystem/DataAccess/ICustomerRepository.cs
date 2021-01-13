using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerById(string id);
        List<Customer> GetAllCustomers();
        Task<bool> Insert(Customer request);
        Task<bool> Delete(string id);
        Task<bool> Update(Customer request);

    }
}
