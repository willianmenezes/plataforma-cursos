using PlataformaDeCursos.Application.Contracts.Request;
using PlataformaDeCursos.Application.Contracts.Response;

namespace PlataformaDeCursos.Application.Interfaces.Authentication;

public interface IAuthenticationService
{
    LoginResponse Login(LoginRequest request);
    RegistrarResponse Register(RegistrarRequest request);
}