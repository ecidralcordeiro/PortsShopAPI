using PortsShop.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PortsShop.Application.DTOs;

public class TesteDTO
{

    [Required]
    public string Email { get;  set; }
    [Required]
    public string Password { get;  set; }
}
