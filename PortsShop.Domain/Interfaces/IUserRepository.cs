using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IUserRepository
{
    Task<User> CreateAsync(User user);
    Task<User> UpdateAsync(User user);
    Task<User> DeleteAsync(int id);
    Task<User> GetByIdAsync(int id);
    Task<IEnumerable<User>> GetAllAsync();
    Task<User> GetUserByLoginAndPassword(string login, string passwordHash);
}
