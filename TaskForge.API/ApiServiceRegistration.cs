using TaskForge.API.CurrentUsers;
using TaskForge.Application;
using TaskForge.Domain;
using TaskForge.Domain.Shared;
using TaskForge.EntityFrameworkCore;
using TaskForge.EntityFrameworkCore.Shared;
using TaskForge.Identity;

namespace TaskForge.API;

public static class ApiServiceRegistration
{
    public static void AddApiServices(this WebApplicationBuilder builder)
    {
        var isDevelopment = builder.Environment.IsDevelopment();
        builder.Services.AddControllers();
        builder.Services.AddDomainServices();
        builder.Services.AddApplicationServices();
        builder.Services.AddIdentityServices(builder.Configuration,isDevelopment);
        builder.Services.AddEntityFrameworkServices(builder.Configuration,isDevelopment);
        builder.Services.AddEntityFrameworkCoreSharedServices();
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddSingleton<ICurrentUser,CurrentUser>();
    }
}
