using Microsoft.EntityFrameworkCore;
using TaskForge.Domain.Projects;
using TaskForge.Domain.Projects.ProjectMembers;
using TaskForge.Domain.Tags;
using TaskForge.Domain.Tasks.TaskItems;

namespace TaskForge.EntityFrameworkCore.DbContexts;

public abstract class ApplicationDbContextBase:DbContext
{
    public ApplicationDbContextBase(DbContextOptions options):base(options)
    {

    }

    public DbSet<Project> Projects => Set<Project>();
    public DbSet<ProjectMember> ProjectMembers => Set<ProjectMember>();
    public DbSet<TaskItem> Tasks => Set<TaskItem>();
    public DbSet<Tag> Tags => Set<Tag>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContextBase).Assembly);
    }
}