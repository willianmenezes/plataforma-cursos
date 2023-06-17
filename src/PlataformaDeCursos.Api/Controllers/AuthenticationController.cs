using Microsoft.AspNetCore.Mvc;
using PlataformaDeCursos.Application.Contracts.Request;
using PlataformaDeCursos.Application.Interfaces.Authentication;

namespace PlataformaDeCursos.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("logar")]
    public IActionResult Logar(LoginRequest request)
    {
        return Ok(_authenticationService.Login(request));
    }

    [HttpPost("registrar")]
    public IActionResult Registrar(RegistrarRequest request)
    {
        return Ok(_authenticationService.Register(request));
    }
}