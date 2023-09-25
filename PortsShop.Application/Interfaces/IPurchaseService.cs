using PortsShop.Application.DTOs;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Interfaces;

public interface IPurchaseService
{
    Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO);
    Task<CategoryDTO> UpdateAsync(CategoryDTO categoryDTO);
    Task<CategoryDTO> DeleteAsync(int id);
    Task<CategoryDTO> GetByIdAsync(int id);
    Task<IEnumerable<CategoryDTO>> GetAllAsync();
}
