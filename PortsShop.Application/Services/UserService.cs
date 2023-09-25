using AutoMapper;
using PortsShop.Application.DTOs;
using PortsShop.Application.Interfaces;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;
using System.Security.Cryptography;
using System.Text;

namespace PortsShop.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<UserDTO> CreateAsync(UserDTO userDTO)
    {
        var user = _mapper.Map<User>(userDTO);
        var createdUser = await _userRepository.CreateAsync(user);
        return _mapper.Map<UserDTO>(createdUser);
    }

    public async Task<UserDTO> DeleteAsync(int id)
    {
        var deletedUser = await _userRepository.DeleteAsync(id);
        return _mapper.Map<UserDTO>(deletedUser);
    }

    public async Task<IEnumerable<UserDTO>> GetAllAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<UserDTO>>(users);
    }

    public async Task<UserDTO> GetByIdAsync(int id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        return _mapper.Map<UserDTO>(user);
    }

    public async Task<UserDTO> GetUserByLoginAndPassword(string login, string password)
    {
        string passwordHash = criptografyPassword(password);
        var user =  await _userRepository.GetUserByLoginAndPassword(login, passwordHash);
        return _mapper.Map<UserDTO>(user);
    }

    public async Task<UserDTO> UpdateAsync(UserDTO userDTO)
    {
        var user = _mapper.Map<User>(userDTO);
        var updatedUser = await _userRepository.UpdateAsync(user);
        return _mapper.Map<UserDTO>(updatedUser);
    }

    public static string criptografyPassword(string password)
    {
        var md5 = MD5.Create();
        byte[] inputBytes = Encoding.ASCII.GetBytes(password);
        byte[] hashBytes = md5.ComputeHash(inputBytes);
        string passwordEncripto = Convert.ToHexString(hashBytes);

        return passwordEncripto;
    }
}
