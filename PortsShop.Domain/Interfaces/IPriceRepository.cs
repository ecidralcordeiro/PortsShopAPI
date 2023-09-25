using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IPriceRepository
{
    Task<Price> CreateAsync(Price price);
    Task<Price> UpdateAsync(Price price);
    Task<Price> DeleteAsync(int id);
    Task<Price> GetByIdAsync(int id);
    Task<IEnumerable<Price>> GetAllAsync();  
}
