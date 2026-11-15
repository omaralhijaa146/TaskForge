using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskForge.EntityFrameworkCore.DbContexts;

namespace TaskForge.EntityFrameworkCore;

public static class EntityFrameworkServiceRegistration
{
    public static IServiceCollection AddEntityFrameworkServices(this IServiceCollection services,IConfiguration configuration,bool isDevelopment=false)
    {
        var connectionString = configuration.GetConnectionString("DbConnectionString");
        
        services.AddDbContext<ApplicationWriteDbContext>(options => options.UseTaskForgeSqlServer(connectionString).EnableDevelopmentLogging(isDevelopment));
        
        services.AddDbContext<ApplicationReadDbContext>(options => options
            .UseTaskForgeSqlServer(connectionString,"__Application_Migrations")
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
        
        return services;
    }
}