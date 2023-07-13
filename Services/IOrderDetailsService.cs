using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface IOrderDetailsService
    {
        Task GetAll();
        Task GetById(int id);
        Task GetByName(string Name);
        Task Insert(OrderDetails orderDetail);
        Task Update(int id, OrderDetails orderDetail);
        Task DeleteById(int id);

    }
}
