namespace TaskForge.Domain.Shared.Audits;

public interface IHasCreationTime
{
    DateTimeOffset CreationTime { get; set; }
}
