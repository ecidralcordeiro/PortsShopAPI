using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class PriceRepository : IPriceRepository
{
    private readonly ApplicationDbContext _context;
    public PriceRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Price> CreateAsync(Price price)
    {
        throw new NotImplementedException();
    }

    public Task<Price> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Price>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Price> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Price> UpdateAsync(Price price)
    {
        throw new NotImplementedException();
    }
}
