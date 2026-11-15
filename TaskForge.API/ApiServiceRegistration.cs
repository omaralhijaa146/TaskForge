using TaskForge.Application;
using TaskForge.EntityFrameworkCore;
using TaskForge.Identity;

namespace TaskForge.API;

public static class ApiServiceRegistration
{
    public static void AddApiServices(this WebApplicationBuilder builder)
    {
        var isDevelopment = builder.Environment.IsDevelopment();
        builder.Services.AddControllers();
        builder.Services.AddApplicationServices();
        builder.Services.AddIdentityServices(builder.Configuration,isDevelopment);
        builder.Services.AddEntityFrameworkServices(builder.Configuration,isDevelopment);
    }
}