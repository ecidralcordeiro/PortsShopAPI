﻿using System.ComponentModel.DataAnnotations;

namespace PortsShop.Application.DTOs;

public class UserDTO
{
    public int Id { get; set; }

    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
}
