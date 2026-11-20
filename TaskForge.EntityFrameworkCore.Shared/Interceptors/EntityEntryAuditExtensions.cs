using Microsoft.EntityFrameworkCore;
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

    internal static void ApplyDeletionAudit(this EntityEntry entry, AuditStamp stamp)
    {
        // Not soft-deletable, so this stays a hard DELETE. Property modification flags
        // play no part in a DELETE command, so there is nothing to protect here.
        if (entry.Entity is not IHasSoftDelete softDeleted)
        {
            return;
        }

        entry.State = EntityState.Modified;
        softDeleted.IsDeleted = true;

        if (entry.Entity is IHasDeletionTime deletionTime)
        {
            deletionTime.DeletionTime = stamp.Now;
        }

        if (entry.Entity is IHasDeletedBy deletedBy)
        {
            deletedBy.DeletedBy = stamp.UserId;
        }

        // Switching state marks every property modified, so narrow the UPDATE back to
        // the deletion columns: creation stamps are immutable, and a soft delete is
        // recorded as a deletion rather than a modification.
        ProtectCreationStamps(entry);
        ProtectModificationStamps(entry);
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

    private static void ProtectModificationStamps(EntityEntry entry)
    {
        if (entry.Entity is IHasModificationTime)
        {
            entry.Property(nameof(IHasModificationTime.ModificationTime)).IsModified = false;
        }

        if (entry.Entity is IHasModifiedBy)
        {
            entry.Property(nameof(IHasModifiedBy.ModifiedBy)).IsModified = false;
        }
    }
}
