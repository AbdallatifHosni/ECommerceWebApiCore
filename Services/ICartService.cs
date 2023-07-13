using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface ICartService
    {
        Task GetAll();
        Task GetById(int id);
        Task GetByName(string name);
        Task Insert(Cart cart);
        Task Update(int id, Cart cart);
        Task DeleteById(int id);



    }
}
