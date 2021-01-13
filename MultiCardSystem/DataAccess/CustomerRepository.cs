using MultiCardSystem.Data.EF;
using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MultiCardDbContext _context;
        public CustomerRepository()
        {
            _context = new MultiCardDbContext();
        }
        public CustomerRepository(MultiCardDbContext Context)
        {
            _context = Context;
        }
        public async Task<bool> Delete(string id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                return false;
            _context.Customers.Remove(customer);
            return await _context.SaveChangesAsync() > 0;
        }

        public List<Customer> GetAllCustomers()
        {
            //var query = from c in _context.Customers
            //            select c;
            //var data = query
            //      .Select(x => new Customer()
            //      {
            //          IDCustomer = x.IDCustomer,
            //          FirstName = x.FirstName,
            //          LastName = x.LastName,
            //          Dob = x.Dob,
            //          CMND = x.CMND,
            //          PhoneNumber = x.PhoneNumber,
            //          Address = x.Address,
            //      }).ToList();
            //return data;
             return _context.Customers.ToList();

        }

        public async Task<Customer> GetCustomerById(string id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return null;
            return customer;

        }

        public async Task<bool> Insert(Customer request)
        {
            var customer = new Customer()
            {
                ID = request.ID,
               // IDCustomer = request.IDCustomer,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Dob = request.Dob,
                CMND = request.CMND,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
            };
            _context.Customers.Add(customer);
           return await _context.SaveChangesAsync()>0; 
            
        }

        public async Task<bool> Update(Customer request)
        {
            var customer = await _context.Customers.FindAsync(request.ID);
            if (customer == null) return false;
         //   if (!string.IsNullOrEmpty(request.IDCustomer))
           //     customer.IDCustomer = request.IDCustomer;
            if (!string.IsNullOrEmpty(request.FirstName))
                customer.FirstName = request.FirstName;
            if (!string.IsNullOrEmpty(request.LastName))
                customer.LastName = request.LastName;
            if (!string.IsNullOrEmpty(request.Dob))
                customer.Dob = request.Dob;
            if (!string.IsNullOrEmpty(request.CMND))
                customer.CMND = request.CMND;
            if (!string.IsNullOrEmpty(request.PhoneNumber))
                customer.PhoneNumber = request.PhoneNumber;
            if (!string.IsNullOrEmpty(request.Address))
                customer.Address = request.Address;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
