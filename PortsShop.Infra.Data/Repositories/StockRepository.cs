using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class StockRepository : IStockRepository { 
    private readonly ApplicationDbContext _context;
    public StockRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Stock> CreateAsync(Stock store)
    {
        throw new NotImplementedException();
    }

    public Task<Stock> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Stock>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Stock> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Stock> UpdateAsync(Stock store)
    {
        throw new NotImplementedException();
    }
}
