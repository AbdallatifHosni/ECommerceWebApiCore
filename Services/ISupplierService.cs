using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface ISupplierService
    {
        Task GetAll();
        Task GetById(int id);
        Task GetByName(string Name);
        Task Insert(Supplier supplier);
        Task Update(int id,Supplier supplier);
        Task DeleteById(int id);

    }
}
