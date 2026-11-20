namespace TaskForge.Domain.Shared.Audits;

public interface IHasDeletionTime
{
    DateTimeOffset? DeletionTime { get; set; }
}
