using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class CartRepository : ICartRepository
{
    private readonly ApplicationDbContext _context;
    public CartRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Cart> CreateAsync(Cart cart)
    {
        throw new NotImplementedException();
    }

    public Task<Cart> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Cart>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Cart> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Cart> UpdateAsync(Cart cart)
    {
        throw new NotImplementedException();
    }
}
