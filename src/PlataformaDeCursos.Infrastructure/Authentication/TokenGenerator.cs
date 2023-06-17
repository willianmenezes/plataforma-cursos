using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using PlataformaDeCursos.Application.Interfaces.Authentication;

namespace PlataformaDeCursos.Infrastructure.Authentication;

public class TokenGenerator : ITokenGenerator
{
    private readonly JwtConfiguration _jwtConfiguration;

    public TokenGenerator(IOptions<JwtConfiguration> options)
    {
        _jwtConfiguration = options.Value;
    }

    public string GenerateToken(Guid userId, string? nome, string? email)
    {
        var assinaturaDeAcesso = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfiguration.ChaveSecreta)),
            SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, nome),
            new Claim(JwtRegisteredClaimNames.Email, email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var tokenDeSeguranca = new JwtSecurityToken(
            claims: claims,
            signingCredentials: assinaturaDeAcesso,
            issuer: _jwtConfiguration.Emissor,
            expires: DateTime.Now.AddMinutes(_jwtConfiguration.ExpiracaoEmMinutos),
            audience: _jwtConfiguration.Destinatarios
        );

        return new JwtSecurityTokenHandler().WriteToken(tokenDeSeguranca);
    }
}