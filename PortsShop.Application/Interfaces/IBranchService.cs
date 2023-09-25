using PortsShop.Application.DTOs;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Interfaces;

public interface IBranchService
{
    Task<BranchDTO> CreateAsync(BranchDTO branchDTO);
    Task<BranchDTO> UpdateAsync(BranchDTO branch);
    Task<BranchDTO> DeleteAsync(int id);
    Task<BranchDTO> GetByIdAsync(int id);
    Task<IEnumerable<BranchDTO>> GetAllAsync();
}
