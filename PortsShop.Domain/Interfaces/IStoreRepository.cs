using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IStoreRepository
{
    Task<Store> CreateAsync(Store store);
    Task<Store> UpdateAsync(Store store);
    Task<Store> DeleteAsync(int id);
    Task<Store> GetByIdAsync(int id);
    Task<IEnumerable<Store>> GetAllAsync();  
}
