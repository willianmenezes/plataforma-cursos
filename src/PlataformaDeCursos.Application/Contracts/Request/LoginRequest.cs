using System.Text.Json.Serialization;

namespace PlataformaDeCursos.Application.Contracts.Request;

public record LoginRequest(
    [property: JsonPropertyName("email")] string? Email,
    [property: JsonPropertyName("senha")] string? Senha);