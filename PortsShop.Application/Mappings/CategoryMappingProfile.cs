using AutoMapper;
using PortsShop.Application.DTOs;
using PortsShop.Domain.Models;

namespace PortsShop.Application.Mappings;

public class CategoryMappingProfile : Profile
{
    public CategoryMappingProfile()
    {
        CreateMap<Category, CategoryDTO>();
        CreateMap<CategoryDTO, Category>();
    }
}