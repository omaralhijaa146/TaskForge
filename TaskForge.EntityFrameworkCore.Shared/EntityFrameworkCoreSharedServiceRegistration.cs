using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TaskForge.EntityFrameworkCore.Shared.Interceptors;

namespace TaskForge.EntityFrameworkCore.Shared;

public static class EntityFrameworkCoreSharedServiceRegistration
{
    public static IServiceCollection AddEntityFrameworkCoreSharedServices(this IServiceCollection services)
    {
        // TryAdd so this stays idempotent if more than one module calls it.
        services.TryAddSingleton<AuditingSaveChangesInterceptor>();
        return services;
    }
}
