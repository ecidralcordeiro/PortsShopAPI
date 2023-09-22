using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface ICategoryRepository
{
    Task<Category> CreateAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task<Category> DeleteAsync(int id);
    Task<Category> GetByIdAsync(int id);
    Task<IEnumerable<Category>> GetAllAsync();  
}
