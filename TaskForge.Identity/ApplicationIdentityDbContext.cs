using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskForge.EntityFrameworkCore.Shared;
using TaskForge.Identity.Models.Roles;
using TaskForge.Identity.Models.Users;

namespace TaskForge.Identity;

public class ApplicationIdentityDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
{
    public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options):base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationIdentityDbContext).Assembly);

        // Must run last: the configuration classes rename the AspNet* tables, and the
        // prefix is applied on top of whatever name each entity ends up with.
        builder.ApplyTablePrefix(TaskForgeDbProperties.DbTablePrefix);
    }
}
