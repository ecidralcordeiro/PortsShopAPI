using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;
    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Category> CreateAsync(Category category)
    {
        _context.Category.Add(category);
        await _context.SaveChangesAsync();

        return category;
    }

    public async Task<Category> DeleteAsync(int id)
    {
        var category = await _context.Category.FindAsync(id);
        if(category != null)
        {
            _context.Category.Remove(category);
        }
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        var categories = await _context.Category.ToListAsync();
        return categories;
    }

    public async Task<Category> GetByIdAsync(int id)
    {
        var category = await _context.Category.FindAsync(id);
        return category;
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        _context.Category.Update(category);
        await _context.SaveChangesAsync();
        return category;
    }
}
