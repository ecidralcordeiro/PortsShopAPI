﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Domain.Account;

public interface IAuthenticate
{
    Task<bool> AuthenticateAsync(string email, string password);
    Task<bool> UserExists(string email);
    public string generateToken(int id, string email);
}
