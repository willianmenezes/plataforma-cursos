using System.Text.Json.Serialization;

namespace PlataformaDeCursos.Application.Contracts.Request;

public record RegistrarRequest
(
    [property: JsonPropertyName("nome")] string? Nome,
    [property: JsonPropertyName("email")] string? Email,
    [property: JsonPropertyName("documento")] string? Documento,
    [property: JsonPropertyName("data_nascimento")] DateTime DataNascimento,
    [property: JsonPropertyName("senha")] string? Senha
);