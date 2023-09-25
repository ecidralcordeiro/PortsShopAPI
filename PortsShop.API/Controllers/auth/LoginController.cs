

using Microsoft.AspNetCore.Mvc;
using PortsShop.Application.DTOs;
using PortsShop.Application.Interfaces;
using PortsShop.Domain.Account;

[ApiController]
[Route("api/token")]
public class LoginController : Controller
{
    private readonly IAuthenticate _authenticateService;
    private readonly IUserService _userService;


    public LoginController(IAuthenticate authenticateService, IUserService userService)
    {
        _authenticateService = authenticateService;
        _userService = userService;
    }


    [HttpPost]
    public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] UserDTO userDTO)
    {
        var authenticate = await _authenticateService.AuthenticateAsync(userDTO.Email, userDTO.Password);
        if (!authenticate)
        {
            return NotFound("Email ou Senha Invalidos");
        }
        var user = await _userService.GetUserByLoginAndPassword(userDTO.Email, userDTO.Password);

        if (user == null)
        {
            return NotFound();
        }
        var token =  _authenticateService.generateToken(user.Id, user.Password);

        return new
        {
            user.Id,
            token,
        };
    }
}