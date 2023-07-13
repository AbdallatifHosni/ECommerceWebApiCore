using E_Commerce.Models;

namespace E_Commerce.Services
{
    public interface IPersonalInfoService
    {
        Task GetAll();
        Task GetById(int id);
        Task GetByName(string Name);
        Task Insert(BillingInfo obj);
        Task Update(int id, BillingInfo obj);
        Task DeleteById(int id);


    }
}
