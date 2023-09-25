using Microsoft.AspNetCore.Mvc;
using PortsShop.Application.DTOs;
using PortsShop.Application.Interfaces;

namespace PorstShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StoreController : Controller
{
    private readonly ICategoryService _categoryService;
    public StoreController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateAsync(CategoryDTO categoryDTO) 
    {
        var createdCategoryDTO = await _categoryService.CreateAsync(categoryDTO);
        if(createdCategoryDTO == null)
        {
            return BadRequest("");
        }
        return Ok(createdCategoryDTO);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateAsync(CategoryDTO categoryDTO)
    {
        var updatedCategoryDTO = await _categoryService.UpdateAsync(categoryDTO);
        if (updatedCategoryDTO == null)
        {
            return BadRequest("");
        }
        return Ok(updatedCategoryDTO);
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        var detetedCategoryDTO = await _categoryService.DeleteAsync(id);
        if (detetedCategoryDTO == null)
        {
            return BadRequest("");
        }
        return Ok(detetedCategoryDTO.Name);
    }

    [HttpGet]
    public async Task<ActionResult> GetAllAsync()
    {
        var categoriesDTO = await _categoryService.GetAllAsync();
      
        return Ok(categoriesDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetByIdAsync(int id)
    {
        var categoryDTO = await _categoryService.GetByIdAsync(id);
        if (categoryDTO == null)
        {
            return NotFound();
        }
        return Ok(categoryDTO);
    }
}
