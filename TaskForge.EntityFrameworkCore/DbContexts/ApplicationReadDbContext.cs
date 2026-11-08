using Microsoft.EntityFrameworkCore;

namespace TaskForge.EntityFrameworkCore.DbContexts;

public class ApplicationReadDbContext:ApplicationDbContextBase
{
    public ApplicationReadDbContext(DbContextOptions<ApplicationReadDbContext> options):base(options)
    {
        
    }

    public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    override public Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        throw new NotImplementedException();
    }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        throw new NotImplementedException();
    }

    public override int SaveChanges()
    {
        throw new NotImplementedException();
    }
}