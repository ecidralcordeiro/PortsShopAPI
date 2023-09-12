using AutoMapper;
using PortsShop.Application.DTOs;
using PortsShop.Application.Interfaces;
using PortsShop.Domain.Interfaces;
using PortsShop.Domain.Models;

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
        var createdUser = await _userRepository.UpdateAsync(user);
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

    public async Task<UserDTO> UpdateAsync(UserDTO userDTO)
    {
        var user = _mapper.Map<User>(userDTO);
        var updatedUser = await _userRepository.UpdateAsync(user);
        return _mapper.Map<UserDTO>(updatedUser);
    }
}
