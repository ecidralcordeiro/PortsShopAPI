using PortsShop.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PortsShop.Application.DTOs;

public class StoreDTO
{
    [IgnoreDataMember]
    public int Id { get; private set; }
    [Required]
    public string CompanyName { get; private set; }
    public string FantasyName { get; private set; }
    [Required]
    public string CNPJ { get; private set; }
    [Required]
    public int IdUser { get; private set; }
    [Required]
    public int IdAdress { get; private set; }
    public Address Address { get; private set; }

}
