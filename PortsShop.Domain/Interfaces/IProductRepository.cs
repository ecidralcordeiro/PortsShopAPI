using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IProductRepository
{
    Task<Product> CreateAsync(Product product);
    Task<Product> UpdateAsync(Product product);
    Task<Product> DeleteAsync(int id);
    Task<Product> GetByIdAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync();  
}
