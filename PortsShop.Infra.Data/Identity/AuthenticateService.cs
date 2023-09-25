using iSAGAAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using PortsShop.Domain.Account;
using PortsShop.Domain.Models;
using PortsShop.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PortsShop.Infra.Data.Identity;

public class AuthenticateService : IAuthenticate
{
    private readonly ApplicationDbContext _context;

    public AuthenticateService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> AuthenticateAsync(string email, string password)
    {
        var passwordHash = CriptografyService.criptografyPassword(password);

        var user = await _context.User.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower() && x.Password.ToLower() == passwordHash.ToLower());
        if (user == null)
        {
            return false;
        }

        return true;
    }

    public string generateToken(int id, string email)
    {
        var token = TokenService.GenerateToken(id, email);
        return token;
    }

    public async Task<bool> UserExists(string email)
    {
        var user = await _context.User.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower());
        if (user == null)
        {
            return false;
        }

        return true;
    }
}
