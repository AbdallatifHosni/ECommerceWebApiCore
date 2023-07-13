using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface IOrderService
    {
        Task GetAll();
        Task GetById(int id);
        Task GetByName(string Name);
        Task Insert(Order order);
        Task Update(int id, Order order);
        Task DeleteById(int id);
    }
}
