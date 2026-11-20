using Microsoft.Extensions.DependencyInjection;
using TaskForge.Domain.Clock;
using TaskForge.Domain.IdGenerators;
using TaskForge.Domain.Shared.Clock;
using TaskForge.Domain.Shared.IdGenerator;

namespace TaskForge.Domain;

public static class DomainServiceRegistration
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.AddSingleton<IIdGenerator, IdGenerator>();

        services.AddSingleton(TimeProvider.System);
        services.AddSingleton<IClock, SystemClock>();

        return services;
    }
}
