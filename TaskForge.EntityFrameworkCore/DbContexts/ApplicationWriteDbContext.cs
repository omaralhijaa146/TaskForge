using Microsoft.EntityFrameworkCore;

namespace TaskForge.EntityFrameworkCore.DbContexts;

public class ApplicationWriteDbContext:ApplicationDbContextBase
{
    public ApplicationWriteDbContext(DbContextOptions<ApplicationWriteDbContext> options):base(options)
    {
        
    }
}