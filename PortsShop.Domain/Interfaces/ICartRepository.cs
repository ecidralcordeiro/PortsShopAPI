using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface ICartRepository
{
    Task<Cart> CreateAsync(Cart cart);
    Task<Cart> UpdateAsync(Cart cart);
    Task<Cart> DeleteAsync(int id);
    Task<Cart> GetByIdAsync(int id);
    Task<IEnumerable<Cart>> GetAllAsync();  
}
