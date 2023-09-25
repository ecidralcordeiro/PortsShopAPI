using iSAGAAPI.Services;
using Microsoft.EntityFrameworkCore;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;

namespace PortsShop.Infra.Data.Repositories;


public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<User> CreateAsync(User user)
    {
        user.Password = CriptografyService.criptografyPassword(user.Password);
        _context.User.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public Task<User> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        var users = await _context.User.ToListAsync();
        return users;
    }

    public async Task<User> GetByIdAsync(int id)
    {
        var user = await _context.User.FindAsync(id);
        return user;
    }

    public async Task<User> UpdateAsync(User user)
    {
        _context.User.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User> GetUserByLoginAndPassword(string email, string password)
    {
        var user = await _context.User.FirstOrDefaultAsync(x=> x.Email.ToLower() == email.ToLower() && x.Password == password);
        return user;
    }
}
