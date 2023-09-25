using PortsShop.Domain.Models;

namespace PortsShop.Domain.Interfaces;

public interface IPersonRepository
{
    Task<Person> CreateAsync(Person person);
    Task<Person> UpdateAsync(Person person);
    Task<Person> DeleteAsync(int id);
    Task<Person> GetByIdAsync(int id);
    Task<IEnumerable<Person>> GetAllAsync();  
}
