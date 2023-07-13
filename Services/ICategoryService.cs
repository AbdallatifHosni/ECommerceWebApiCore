using E_Commerce.DTO;
using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface ICategoryService
    {
        Task<IList<Category>> GetAll();
        Task<Category> GetById(int id);
        Task<Category> GetByName(string name);
        Task<int> Insert(CategoryDto category);
        Task<int> Update(int id, CategoryDto category);
        Task<int> DeleteById(int id);
    }
}
