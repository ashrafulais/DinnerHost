using DinnerHost.Application.Common.Interfaces.Authentication;
using DinnerHost.Application.Common.Interfaces.Services;
using DinnerHost.Infrastructure.Authentication;
using DinnerHost.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerHost.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}