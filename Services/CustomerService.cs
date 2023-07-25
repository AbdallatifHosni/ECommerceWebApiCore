using E_Commerce.Data;
using E_Commerce.DTO;
using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;

namespace E_Commerce.Services
{
    public class CustomerService:ICustomerService
    {
        private readonly ECommerceContext _context;
        public CustomerService(ECommerceContext context ) {
            _context = context;
        }

        //GetAllCustomer
        public async Task<IList<Customer>>GetAll()
        {
            return await _context.Customers.ToListAsync();

        }
        public async Task<Customer> GetById(int id)
        {
            var item = await _context.Customers.FindAsync(id);
            return item;

        }
        public async Task<Customer> GetByName(string name)
        {
            var item = await _context.Customers.FirstOrDefaultAsync(e => e.FirstName == name);
            return item;

        }
        public async Task<int> Insert(CustomerDto dto)
        {
            var ins = new Customer
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                ContactName = dto.ContactName,
            };
            await _context.Customers.AddAsync(ins);
           int raw= _context.SaveChanges();
            return raw;

        }
        public async Task<int>  Update(int id, CustomerDto customer)
        {
           var old= GetById(id);
            var nitem = new Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                ContactName = customer.ContactName,

            };
            _context.Customers.Update(nitem);
            int raw= _context.SaveChanges();
            return raw;

        }
        public async Task<int> DeleteById(int id)
        {
            var del = GetById(id);
             _context.Remove(del);
             var raw =_context.SaveChanges();
            return raw;


        }

    }
}
