using E_Commerce.Data;
using E_Commerce.DTO;
using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace E_Commerce.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ECommerceContext _context;
        public CategoryService(ECommerceContext context)
        {
            _context = context;

        }


        public async Task<IList<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetById(int id)
        {
           var category= await _context.Categories.FindAsync(id);

            return category;
        }

        public async Task<Category> GetByName(string name)
        {
            var result = await _context.Categories.FirstOrDefaultAsync(ss => ss.Name == name);
            return result;
        }

        public async Task<int> Insert(CategoryDto dto)
        {
            var item = new Category
            {
                Name=dto.Name,
                Description=dto.Description,

            };
            _context.Categories.Add(item);
             var raw =await _context.SaveChangesAsync();
            return raw;

        }

        public async Task<int> Update(int id, CategoryDto dto)
        {
           var old= _context.Categories.FirstOrDefault(x=>x.CategoryID==id);
            var cat = new Category
            {
                Name = dto.Name,
                Description = dto.Description,
            };
            _context.Categories.Update(cat);
           var raw=await _context.SaveChangesAsync();
            return raw;
        }
        public async Task<int> DeleteById(int id)
        {
           var item = _context.Categories.FirstOrDefault(u=>u.CategoryID==id);
            _context.Categories.Remove(item);
            return await _context.SaveChangesAsync();
        }
    }
}
