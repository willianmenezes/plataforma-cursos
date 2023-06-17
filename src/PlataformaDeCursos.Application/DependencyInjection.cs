using Microsoft.Extensions.DependencyInjection;
using PlataformaDeCursos.Application.Interfaces.Authentication;
using PlataformaDeCursos.Application.Services.Authentication;

namespace PlataformaDeCursos.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}