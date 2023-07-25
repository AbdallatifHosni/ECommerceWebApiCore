using E_Commerce.Models;
using E_Commerce.DTO;

namespace E_Commerce.Services
{
    public interface ICustomerService
    {
        Task<IList<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task<Customer> GetByName(string name);
        Task<int> Insert(CustomerDto customer);
        Task<int> Update(int id, CustomerDto customer);
        Task<int> DeleteById(int id);
    }
}
