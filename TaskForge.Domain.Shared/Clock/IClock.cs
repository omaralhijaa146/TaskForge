namespace TaskForge.Domain.Shared.Clock;

public interface IClock
{
    DateTimeOffset NowUtc { get; }
}
