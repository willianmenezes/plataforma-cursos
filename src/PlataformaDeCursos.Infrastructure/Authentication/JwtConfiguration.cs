namespace PlataformaDeCursos.Infrastructure.Authentication;

public class JwtConfiguration
{
    public string ChaveSecreta { get; init; }
    public int ExpiracaoEmMinutos { get; init; }
    public string Emissor { get; init; }
    public string Destinatarios { get; init; }
}