using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;

namespace PortsShop.Infra.Data.Repositories;


public class SKURepository : ISKURepository
{
    private readonly ApplicationDbContext _context;
    public SKURepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<SKU> CreateAsync(SKU sku)
    {
        throw new NotImplementedException();
    }

    public Task<SKU> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SKU>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<SKU> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SKU> UpdateAsync(SKU sku)
    {
        throw new NotImplementedException();
    }
}



   

