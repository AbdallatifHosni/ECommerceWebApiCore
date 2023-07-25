using E_Commerce.DTO;
using E_Commerce.Models;
using E_Commerce.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IList<Product>> GetAll()
        {
            return await _service.GetAll();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id:int}")]
        public async Task<Product> GetById(int id)
        {
            return await _service.GetById(id);
            
        }
        [HttpGet("{name:alpha}")]
        public async Task<Product> GetByName(string  name)
        {
            return await _service.GetByName(name);

        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<int> Post(ProductDto model)
        {
            return await  _service.Insert(model);

        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id:int}")]
        public async Task<int> Put(int id,[FromBody] ProductDto model)
        {
            return await _service.Update(id, model);

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<int> Delete(int id)
        {
            return await _service.DeleteById(id);
        }
    }
}
