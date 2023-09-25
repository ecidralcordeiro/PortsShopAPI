using AutoMapper;
using PortsShop.Application.DTOs;
using PortsShop.Application.Interfaces;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Services;

public class BranchService : IBranchService
{
    private readonly IBranchRepository _branchRepository;
    private readonly IMapper _mapper;
    public BranchService(IBranchRepository branchRepository, IMapper mapper)
    {
        _branchRepository = branchRepository;
        _mapper = mapper;
    }

    public async Task<BranchDTO> CreateAsync(BranchDTO branchDTO)
    {
        var branch = _mapper.Map<Branch>(branchDTO);
        var createdBranch = await _branchRepository.CreateAsync(branch);
        return _mapper.Map<BranchDTO>(createdBranch);
    }

    public async Task<BranchDTO> DeleteAsync(int id)
    {
        var deletedCategory = await _branchRepository.DeleteAsync(id);
        return _mapper.Map<BranchDTO>(deletedCategory);
    }

    public async Task<IEnumerable<BranchDTO>> GetAllAsync()
    {
        var branch = await _branchRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<BranchDTO>>(branch);
    }

    public async Task<BranchDTO> GetByIdAsync(int id)
    {
        var branch = await _branchRepository.GetByIdAsync(id);
        return _mapper.Map<BranchDTO>(branch);
    }

    public async Task<BranchDTO> UpdateAsync(BranchDTO branchDTO)
    {
        var branch = _mapper.Map<Branch>(branchDTO);
        var updatedBranch = await _branchRepository.UpdateAsync(branch);
        return _mapper.Map<BranchDTO>(updatedBranch);
    }
}
