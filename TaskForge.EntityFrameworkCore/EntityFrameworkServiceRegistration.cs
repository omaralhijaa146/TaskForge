using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskForge.EntityFrameworkCore.DbContexts;

namespace TaskForge.EntityFrameworkCore;

public static class EntityFrameworkServiceRegistration
{
    public static IServiceCollection AddEntityFrameworkServices(this IServiceCollection services,IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DbConnectionString");
        services.AddDbContext<ApplicationWriteDbContext>(options => options.UseSqlServer(connectionString));
        services.AddDbContext<ApplicationReadDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });
        return services;
    }
}