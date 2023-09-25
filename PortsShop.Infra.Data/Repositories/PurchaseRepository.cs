using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class PurchaseRepository : IPurchaseRepository
{
    private readonly ApplicationDbContext _context;
    public PurchaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Purchase> AddPrice(Price id)
    {
        throw new NotImplementedException();
    }

    public Task<Purchase> AddSKU(SKU id)
    {
        throw new NotImplementedException();
    }

    public Task<Purchase> AddUser(User id)
    {
        throw new NotImplementedException();
    }

    public Task<Purchase> CreateAsync(Purchase purchase)
    {
        throw new NotImplementedException();
    }

    public Task<Purchase> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Purchase>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Purchase> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Purchase> UpdateAsync(Purchase purchase)
    {
        throw new NotImplementedException();
    }
}



