using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using TaskForge.Domain.Shared;
using TaskForge.Domain.Shared.Clock;

namespace TaskForge.EntityFrameworkCore.Shared.Interceptors;

internal sealed class AuditingSaveChangesInterceptor : SaveChangesInterceptor
{
    private readonly ICurrentUser _currentUser;
    private readonly IClock _clock;

    public AuditingSaveChangesInterceptor(ICurrentUser currentUser, IClock clock)
    {
        ArgumentNullException.ThrowIfNull(currentUser);
        ArgumentNullException.ThrowIfNull(clock);
        _currentUser = currentUser;
        _clock = clock;
    }

    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result,
        CancellationToken cancellationToken = new CancellationToken())
    {
        Stamp(eventData.Context);
        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        Stamp(eventData.Context);
        return base.SavingChanges(eventData, result);
    }

    private void Stamp(DbContext? context)
    {
        if (context is null)
        {
            return;
        }

        // Read once per save so every row in the batch shares one instant and actor.
        var stamp = new AuditStamp(_clock.NowUtc, _currentUser.Id);

        foreach (var entry in context.ChangeTracker.Entries())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.ApplyCreationAudit(stamp);
                    break;

                case EntityState.Modified:
                    entry.ApplyModificationAudit(stamp);
                    break;

                case EntityState.Deleted:
                    entry.ApplyDeletionAudit(stamp);
                    break;
            }
        }
    }
}
