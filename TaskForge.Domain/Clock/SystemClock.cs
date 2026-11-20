using TaskForge.Domain.Shared.Clock;

namespace TaskForge.Domain.Clock;

/// <summary>
/// Backed by <see cref="TimeProvider"/> so tests can substitute a FakeTimeProvider
/// without replacing the <see cref="IClock"/> abstraction.
/// </summary>
public sealed class SystemClock : IClock
{
    private readonly TimeProvider _timeProvider;

    public SystemClock(TimeProvider timeProvider)
    {
        ArgumentNullException.ThrowIfNull(timeProvider);
        _timeProvider = timeProvider;
    }

    public DateTimeOffset NowUtc => _timeProvider.GetUtcNow();
}
