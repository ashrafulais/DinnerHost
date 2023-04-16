using DinnerHost.Application.Common.Interfaces.Authentication;
using DinnerHost.Application.Common.Interfaces.Persistence;
using DinnerHost.Application.Common.Interfaces.Services;
using DinnerHost.Infrastructure.Authentication;
using DinnerHost.Infrastructure.Persistence;
using DinnerHost.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerHost.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}