using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IBranchRepository
{
    Task<Branch> CreateAsync(Branch branch);
    Task<Branch> UpdateAsync(Branch branch);
    Task<Branch> DeleteAsync(int id);
    Task<Branch> GetByIdAsync(int id);
    Task<IEnumerable<Branch>> GetAllAsync();  
}
