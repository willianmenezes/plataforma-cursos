using PlataformaDeCursos.Application.Contracts.Request;
using PlataformaDeCursos.Application.Contracts.Response;
using PlataformaDeCursos.Application.Interfaces.Authentication;

namespace PlataformaDeCursos.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly ITokenGenerator _tokenGenerator;

    public AuthenticationService(ITokenGenerator tokenGenerator)
    {
        _tokenGenerator = tokenGenerator;
    }

    public LoginResponse Login(LoginRequest request)
    {
        // validar dados da request
        
        // buscar o usuario pelo email
        
        // validar email e senha do usuario com dados do banco
        
        // gerar token JTW e retornar dados do token

        return default!;
    }

    public RegistrarResponse Register(RegistrarRequest request)
    {
        // validar dados da request
        
        // valida se usuario ja existe
        
        //registrar usuario

        // gerar token JTW e retornar dados do token
        var idUsuario = Guid.NewGuid();
        var token = _tokenGenerator.GenerateToken(idUsuario, request.Nome, request.Email);

        return new RegistrarResponse()
        {
            DataNascimento = request.DataNascimento,
            Documento = request.Documento,
            Email = request.Email,
            Token = token,
            Nome = request.Nome,
            Id = idUsuario
        };
    }
}