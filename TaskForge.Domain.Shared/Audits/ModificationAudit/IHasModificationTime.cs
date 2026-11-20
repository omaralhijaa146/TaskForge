namespace TaskForge.Domain.Shared.Audits;

public interface IHasModificationTime
{
    DateTimeOffset? ModificationTime { get; set; }
}
