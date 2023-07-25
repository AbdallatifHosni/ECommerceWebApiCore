using E_Commerce.Data;
using E_Commerce.DTO;
using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Services
{
    public class ProductService :IProductService
    {
        private readonly ECommerceContext _context;

        public ProductService(ECommerceContext context)
        {
           _context = context;
        }

        public Task<int> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
           
        }

        public async Task<Product> GetById(int id)
        {
           var obj=await  _context.Products.FindAsync(id);
            return obj;
        }

        public async Task<Product> GetByName(string name)
        {
            var pro= await _context.Products.FirstOrDefaultAsync(xx=>xx.ProductName==name);
            return pro;
        }

        public async Task<int> Insert(ProductDto dto)
        {
            Product product = new Product
            {
                ProductID = dto.ProductID,
                ProductName = dto.ProductName,
                ProductDescription = dto.Description
            };
            _context.Products.Add(product);
             var raw= await _context.SaveChangesAsync();
            return raw;
               
        }

        public async Task<int> Update(int id, ProductDto dto)
        {
            var old = _context.Products.Find(id);
            Product product = new Product
            {
                ProductID = dto.ProductID,
                ProductName = dto.ProductName,
                ProductDescription = dto.Description
            };
            _context.Products.Update(product);
            var raw=await _context.SaveChangesAsync();
            return raw;


        }
    }
}
