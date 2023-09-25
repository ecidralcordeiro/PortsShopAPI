
using Microsoft.IdentityModel.Tokens;
using PortsShop.Infra.Data.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace iSAGAAPI.Services;

public static class TokenService
{
    public static string GenerateToken(int id, string email) {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(Settings.Secret);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("id",id.ToString()),
                new Claim("email",email)
            }),
            Expires = DateTime.Now.AddHours(8),
            SigningCredentials = new SigningCredentials(
             new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}
