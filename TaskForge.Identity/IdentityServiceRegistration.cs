using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskForge.Identity.Models.Roles;
using TaskForge.Identity.Models.Users;

namespace TaskForge.Identity;

public static class IdentityServiceRegistration
{
    public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration configuration,bool isDevelopment=false)
    {
        var connectionString = configuration.GetConnectionString("DbConnectionString");
        
        services.AddDbContext<ApplicationIdentityDbContext>(options =>
            options.UseTaskForgeSqlServer(connectionString, "__IdentityMigrationsHistory"));

        services.AddIdentityCore<ApplicationUser>()
            .AddRoles<ApplicationRole>()
            .AddEntityFrameworkStores<ApplicationIdentityDbContext>();
        return services;
    }
}