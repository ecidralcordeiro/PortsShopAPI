using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _context;
    public AddressRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Address> CreateAsync(Address address)
    {
        throw new NotImplementedException();
    }

    public Task<Address> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Address>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Address> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Address> UpdateAsync(Address address)
    {
        throw new NotImplementedException();
    }
}
