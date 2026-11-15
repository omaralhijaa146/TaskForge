// Declared in the EF Core namespace so it is discoverable wherever a DbContext is
// registered, following the convention used by the provider packages themselves.
namespace Microsoft.EntityFrameworkCore;

public static class TaskForgeDbContextOptionsExtensions
{
    public static DbContextOptionsBuilder UseTaskForgeSqlServer(
        this DbContextOptionsBuilder builder,
        string? connectionString,
        string? migrationsHistoryTable = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(connectionString);

        return builder.UseSqlServer(connectionString, sql =>
        {
            // Shared provider-level defaults go here, e.g. sql.EnableRetryOnFailure().
            if (migrationsHistoryTable is not null)
            {
                sql.MigrationsHistoryTable(migrationsHistoryTable);
            }
        });
    }

    public static DbContextOptionsBuilder EnableDevelopmentLogging(this  DbContextOptionsBuilder builder,bool isDevelopment)
    {
        if (isDevelopment)
        {
            builder.EnableDetailedErrors();
            builder.EnableSensitiveDataLogging();
        }
        return builder;
    }
}
