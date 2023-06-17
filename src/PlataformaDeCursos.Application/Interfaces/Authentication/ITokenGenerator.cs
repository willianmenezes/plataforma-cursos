namespace PlataformaDeCursos.Application.Interfaces.Authentication;

public interface ITokenGenerator
{
    string GenerateToken(Guid userId, string? nome, string? email);
}