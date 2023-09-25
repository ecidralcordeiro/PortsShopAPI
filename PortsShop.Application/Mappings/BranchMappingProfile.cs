using AutoMapper;
using PortsShop.Application.DTOs;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Mappings;

public class BranchMappingProfile : Profile
{
    public BranchMappingProfile()
    {
        CreateMap<Branch, BranchDTO>();
        CreateMap<BranchDTO, Branch>();
    }
}