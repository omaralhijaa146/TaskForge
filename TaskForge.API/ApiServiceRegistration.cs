using TaskForge.Application;
using TaskForge.EntityFrameworkCore;
using TaskForge.Identity;

namespace TaskForge.API;

public static class ApiServiceRegistration
{
    public static void AddApiServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddApplicationServices();
        builder.Services.AddIdentityServices(builder.Configuration);
        builder.Services.AddEntityFrameworkServices(builder.Configuration);
    }
}