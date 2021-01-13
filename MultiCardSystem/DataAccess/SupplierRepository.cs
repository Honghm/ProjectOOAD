using MultiCardSystem.Data.EF;
using MultiCardSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.DataAccess
{
    public class SupplierRepository : ISupplierRepository
    {

        private readonly MultiCardDbContext _context;
        public SupplierRepository()
        {
            _context = new MultiCardDbContext();
        }
        public SupplierRepository(MultiCardDbContext Context)
        {
            _context = Context;
        }
        public async Task<bool> Delete(string id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier == null) return false;
            _context.Suppliers.Remove(supplier);
            return await _context.SaveChangesAsync() > 0;
        }

        public List<Supplier> GetAllSuppliers()
        {
            //var query = from c in _context.Suppliers
            //            select c;
            //var data = query
            //    .Select(x => new Supplier()
            //    {
            //        IDSupplier = x.IDSupplier,
            //        SupplierName = x.SupplierName,
            //    }).ToList();
            //return data;
            return _context.Suppliers.ToList();
        }

        public async Task<Supplier> GetSupplierById(string id)
        {
            var supplier = await _context.Suppliers.FindAsync(id);
            if (supplier == null) return null;
            return supplier;
        }

        public async Task<bool> Insert(Supplier request)
        {
            var supplier = new Supplier()
            {
                IDSupplier = request.IDSupplier,
                SupplierName = request.SupplierName,

            };
            _context.Suppliers.Add(supplier);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(Supplier request)
        {
            var supplier = await _context.Suppliers.FindAsync(request.IDSupplier);
            if (supplier == null) return false;
            if (!string.IsNullOrEmpty(request.IDSupplier))
                supplier.IDSupplier = request.IDSupplier;
            if (!string.IsNullOrEmpty(request.SupplierName))
                supplier.SupplierName = request.SupplierName;
            return await _context.SaveChangesAsync() > 0;
        }
        //public Task<bool> Delete(string id)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Supplier> GetAllSuppliers()
        //{
        //    using(MultiCardDbContext dbContext = new MultiCardDbContext())
        //    {
        //     return dbContext.Suppliers.ToList();
        //    }
        //}

        //public Task<Supplier> GetSupplierById(string id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> Insert(Supplier request)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> Update(Supplier request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
