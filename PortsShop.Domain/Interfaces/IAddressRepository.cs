using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IAddressRepository
{
    Task<Address> CreateAsync(Address address);
    Task<Address> UpdateAsync(Address address);
    Task<Address> DeleteAsync(int id);
    Task<Address> GetByIdAsync(int id);
    Task<IEnumerable<Address>> GetAllAsync();  
}
