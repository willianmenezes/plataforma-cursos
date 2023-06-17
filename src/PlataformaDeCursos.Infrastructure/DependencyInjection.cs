using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlataformaDeCursos.Application.Interfaces.Authentication;
using PlataformaDeCursos.Infrastructure.Authentication;

namespace PlataformaDeCursos.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        ConfigurationManager builderConfiguration)
    {
        services.Configure<JwtConfiguration>(builderConfiguration.GetSection(nameof(JwtConfiguration)));
        services.AddScoped<ITokenGenerator, TokenGenerator>();
        return services;
    }
}