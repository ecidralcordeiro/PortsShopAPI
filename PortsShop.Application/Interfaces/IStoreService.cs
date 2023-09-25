using PortsShop.Application.DTOs;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Interfaces;

public interface IStoreService
{
    Task<StoreDTO> CreateAsync(StoreDTO storeDTO);
    Task<StoreDTO> UpdateAsync(StoreDTO storeDTO);
    Task<StoreDTO> DeleteAsync(int id);
    Task<StoreDTO> GetByIdAsync(int id);
    Task<IEnumerable<StoreDTO>> GetAllAsync();
}
