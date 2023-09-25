using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class BranchRepository : IBranchRepository
{
    private readonly ApplicationDbContext _context;
    public BranchRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Branch> CreateAsync(Branch branch)
    {
        throw new NotImplementedException();
    }

    public Task<Branch> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Branch>> GetAllAsync()
    {
        var branchs = await _context.Branch.ToListAsync();
        return branchs;
    }

    public Task<Branch> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Branch> UpdateAsync(Branch branch)
    {
        throw new NotImplementedException();
    }
}
