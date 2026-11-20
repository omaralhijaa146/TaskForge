using Microsoft.EntityFrameworkCore.ChangeTracking;
using TaskForge.Domain.Shared.Audits;

namespace TaskForge.EntityFrameworkCore.Shared.Interceptors;

internal static class EntityEntryAuditExtensions
{
    internal static void ApplyCreationAudit(this EntityEntry entry, AuditStamp stamp)
    {
        if (entry.Entity is IHasCreationTime created)
        {
            created.CreationTime = stamp.Now;
        }

        if (entry.Entity is IHasCreatedBy createdBy)
        {
            createdBy.CreatedBy = stamp.UserId;
        }
    }

    internal static void ApplyModificationAudit(this EntityEntry entry, AuditStamp stamp)
    {
        if (entry.Entity is IHasModificationTime modified)
        {
            modified.ModificationTime = stamp.Now;
        }

        if (entry.Entity is IHasModifiedBy modifiedBy)
        {
            modifiedBy.ModifiedBy = stamp.UserId;
        }

        ProtectCreationStamps(entry);
    }

    private static void ProtectCreationStamps(EntityEntry entry)
    {
        if (entry.Entity is IHasCreationTime)
        {
            entry.Property(nameof(IHasCreationTime.CreationTime)).IsModified = false;
        }

        if (entry.Entity is IHasCreatedBy)
        {
            entry.Property(nameof(IHasCreatedBy.CreatedBy)).IsModified = false;
        }
    }
}
