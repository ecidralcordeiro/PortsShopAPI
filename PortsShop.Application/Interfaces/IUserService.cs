using PortsShop.Application.DTOs;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Interfaces;

public interface IUserService
{
    Task<UserDTO> CreateAsync(UserDTO userDto);
    Task<UserDTO> UpdateAsync(UserDTO userDto);
    Task<UserDTO> DeleteAsync(int id);
    Task<UserDTO> GetByIdAsync(int id);
    Task<UserDTO> GetUserByLoginAndPassword(string login, string password);
    Task<IEnumerable<UserDTO>> GetAllAsync();
}
