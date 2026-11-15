namespace Microsoft.EntityFrameworkCore;

public static class TaskForgeModelBuilderExtensions
{
    public static ModelBuilder ApplyTablePrefix(this ModelBuilder modelBuilder, string prefix)
    {
        foreach (var entityType in modelBuilder.Model.GetEntityTypes() )
        {
            var tableName = entityType.GetTableName();

            if (tableName is null)
            {
                continue;
            }

            if (tableName.StartsWith(prefix, StringComparison.Ordinal))
            {
                continue;
            }
            entityType.SetTableName(prefix+tableName);
        }
        return modelBuilder;
    }
}