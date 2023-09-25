using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace PortsShop.Application.DTOs;

public class BranchDTO
{
    [IgnoreDataMember]
    public int Id { get; private set; }

    [Required]
    public string Name { get; set; }

}
