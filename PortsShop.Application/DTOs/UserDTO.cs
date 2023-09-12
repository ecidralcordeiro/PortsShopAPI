using PortsShop.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PortsShop.Application.DTOs;

public class UserDTO
{
    [IgnoreDataMember]
    public long Id { get; private set; }
    public long? IdPerson { get; private set; }
    public long? IdStore { get; private set; }
    [Required]
    public string Email { get; private set; }
    [Required]

    public string Password { get; private set; }
    public Person Person { get; private set; }

}
