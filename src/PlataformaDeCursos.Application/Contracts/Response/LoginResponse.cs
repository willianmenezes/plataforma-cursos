using System.Text.Json.Serialization;

namespace PlataformaDeCursos.Application.Contracts.Response;

public class LoginResponse
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
    
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    
    [JsonPropertyName("token")]
    public string? Token { get; set; }
}