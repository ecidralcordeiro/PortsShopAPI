using AutoMapper;
using PortsShop.Application.DTOs;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Mappings;

public class UserMappingProfile : Profile 
{
    public UserMappingProfile() 
    { 
        CreateMap<User, UserDTO>();
        CreateMap<UserDTO, User>();
    }
}
