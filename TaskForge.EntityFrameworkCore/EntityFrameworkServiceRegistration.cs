using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskForge.EntityFrameworkCore.DbContexts;
using TaskForge.EntityFrameworkCore.Shared;

namespace TaskForge.EntityFrameworkCore;

public static class EntityFrameworkServiceRegistration
{
    public static IServiceCollection AddEntityFrameworkServices(this IServiceCollection services,IConfiguration configuration,bool isDevelopment=false)
    {
        var connectionString = configuration.GetConnectionString("DbConnectionString");
        
        services.AddDbContext<ApplicationWriteDbContext>((sp,options) => options
            .UseTaskForgeSqlServer(connectionString)
            .EnableDevelopmentLogging(isDevelopment)
            .UseTaskForgeInterceptors(sp));
        
        services.AddDbContext<ApplicationReadDbContext>(options => options
            .UseTaskForgeSqlServer(connectionString)
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

        
        
        return services;
    }
}