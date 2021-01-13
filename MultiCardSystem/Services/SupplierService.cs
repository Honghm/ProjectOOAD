using MultiCardSystem.Data.Entities;
using MultiCardSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCardSystem.Services
{
    public  class SupplierService
    {
        //static ISupplierRepository repository;
        //static SupplierService()
        //{
        //    repository = new SupplierRepository();
        //}
        //public static List<Supplier> GetAllSupplier()
        //{
        //    return repository.GetAllSuppliers();
        //}

        private  readonly ISupplierRepository _SupplierRepository;
        public  SupplierService()
        {
            _SupplierRepository = new SupplierRepository(new Data.EF.MultiCardDbContext());
        }
        public SupplierService(ISupplierRepository supplierRepository)
        {
            _SupplierRepository = supplierRepository;
        }

        public async Task<bool> Delete(string id)
        {
            return await _SupplierRepository.Delete(id);
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _SupplierRepository.GetAllSuppliers();
        }

        public async Task<Supplier> GetSupplierById(string id)
        {
            return await _SupplierRepository.GetSupplierById(id);
        }

        public async Task<bool> Insert(Supplier request)
        {
            return await _SupplierRepository.Insert(request);
        }
        public async Task<bool> Update(Supplier request)
        {
            return await _SupplierRepository.Update(request);
        }


    }
}
