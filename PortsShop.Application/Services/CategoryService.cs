using AutoMapper;
using PortsShop.Application.DTOs;
using PortsShop.Application.Interfaces;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<CategoryDTO> CreateAsync(CategoryDTO categoryDTO)
    {
        var cattegory = _mapper.Map<Category>(categoryDTO);
        var createdCategory = await _categoryRepository.CreateAsync(cattegory);
        return _mapper.Map<CategoryDTO>(createdCategory);
    }

    public async Task<CategoryDTO> DeleteAsync(int id)
    {
        var deletedCategory = await _categoryRepository.DeleteAsync(id);
        return _mapper.Map<CategoryDTO>(deletedCategory);
    }

    public async Task<IEnumerable<CategoryDTO>> GetAllAsync()
    {
        var cattegories = await _categoryRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<CategoryDTO>>(cattegories);
    }

    public async Task<CategoryDTO> GetByIdAsync(int id)
    {
        var category = await _categoryRepository.GetByIdAsync(id);
        return _mapper.Map<CategoryDTO>(category);
    }

    public async Task<CategoryDTO> UpdateAsync(CategoryDTO userDTO)
    {
        var category = _mapper.Map<Category>(userDTO);
        var updatedCategory = await _categoryRepository.UpdateAsync(category);
        return _mapper.Map<CategoryDTO>(updatedCategory);
    }
}
