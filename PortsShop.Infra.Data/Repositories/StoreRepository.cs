using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class StoreRepository : IStoreRepository
{
    private readonly ApplicationDbContext _context;
    public StoreRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Store> CreateAsync(Store store)
    {
        throw new NotImplementedException();
    }

    public Task<Store> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Store>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Store> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Store> UpdateAsync(Store store)
    {
        throw new NotImplementedException();
    }
}
