using MultiCardSystem.Data.Entities;
using MultiCardSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;
        public CustomerService()
        {
            _CustomerRepository = new CustomerRepository(new Data.EF.MultiCardDbContext());
        }
        public CustomerService(ICustomerRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
        }

        public async Task<bool> Delete(string id)
        {
            return await _CustomerRepository.Delete(id);
        }
        public List<Customer> GetAllCustomers()
        {
            return _CustomerRepository.GetAllCustomers();
        }
        
        public async Task<Customer> GetCustomerById(string id)
        {
            return await _CustomerRepository.GetCustomerById(id);
        }

        public async Task<bool> Insert(Customer request)
        {
            return await _CustomerRepository.Insert(request);
        }

        public async Task<bool> Update(Customer request)
        {
            return await _CustomerRepository.Update(request);
        }

    }
}
