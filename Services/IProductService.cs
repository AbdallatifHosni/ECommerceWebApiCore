using E_Commerce.DTO;
using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface IProductService
    {
        Task<IList<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> GetByName(string name);
        Task <int> Insert(ProductDto product);
        Task<int> Update(int id , ProductDto product);
        Task<int> DeleteById(int id);
    }
}
