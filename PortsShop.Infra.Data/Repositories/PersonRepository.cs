using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System.Data;

namespace PortsShop.Infra.Data.Repositories;


public class PersonRepository : IPersonRepository
{
    private readonly ApplicationDbContext _context;
    public PersonRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Task<Person> CreateAsync(Person person)
    {
        throw new NotImplementedException();
    }

    public Task<Person> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Person>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Person> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Person> UpdateAsync(Person person)
    {
        throw new NotImplementedException();
    }
}
