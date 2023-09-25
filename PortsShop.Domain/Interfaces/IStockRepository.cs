using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IStockRepository
{
    Task<Stock> CreateAsync(Stock store);
    Task<Stock> UpdateAsync(Stock store);
    Task<Stock> DeleteAsync(int id);
    Task<Stock> GetByIdAsync(int id);
    Task<IEnumerable<Stock>> GetAllAsync();  
}
