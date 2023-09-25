using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface ISKURepository
{
    Task<SKU> CreateAsync(SKU sku);
    Task<SKU> UpdateAsync(SKU sku);
    Task<SKU> DeleteAsync(int id);
    Task<SKU> GetByIdAsync(int id);
    Task<IEnumerable<SKU>> GetAllAsync();  
}
