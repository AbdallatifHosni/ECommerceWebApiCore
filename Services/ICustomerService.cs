using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface ICustomerService
    {
        Task GetAll();
        Task GetById(int id);
        Task GetByName(string name);
        Task Insert(Customer customer);
        Task Update(int id, Customer customer);
        Task DeleteById(int id);
    }
}
