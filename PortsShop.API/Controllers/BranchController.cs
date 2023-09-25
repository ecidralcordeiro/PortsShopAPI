using Microsoft.AspNetCore.Mvc;
using PortsShop.Application.DTOs;
using PortsShop.Application.Interfaces;

namespace PorstShop.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BranchController : Controller
{
    private readonly IBranchService _branchService;
    public BranchController(IBranchService branchService)
    {
        _branchService = branchService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateAsync(BranchDTO branchDTO) 
    {
        var createdCategoryDTO = await _branchService.CreateAsync(branchDTO);
        if(createdCategoryDTO == null)
        {
            return BadRequest("");
        }
        return Ok(createdCategoryDTO);
    }

    [HttpPut]
    public async Task<ActionResult> UpdateAsync(BranchDTO branchDTO)
    {
        var updatedCategoryDTO = await _branchService.UpdateAsync(branchDTO);
        if (updatedCategoryDTO == null)
        {
            return BadRequest("");
        }
        return Ok(updatedCategoryDTO);
    }

    [HttpDelete]
    public async Task<ActionResult> DeleteAsync(int id)
    {
        var detetedCategoryDTO = await _branchService.DeleteAsync(id);
        if (detetedCategoryDTO == null)
        {
            return BadRequest("");
        }
        return Ok(detetedCategoryDTO.Name);
    }

    [HttpGet]
    public async Task<ActionResult> GetAllAsync()
    {
        var categoriesDTO = await _branchService.GetAllAsync();
      
        return Ok(categoriesDTO);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetByIdAsync(int id)
    {
        var categoryDTO = await _branchService.GetByIdAsync(id);
        if (categoryDTO == null)
        {
            return NotFound();
        }
        return Ok(categoryDTO);
    }
}
