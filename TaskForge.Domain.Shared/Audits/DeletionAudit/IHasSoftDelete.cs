namespace TaskForge.Domain.Shared.Audits;

public interface IHasSoftDelete
{
    bool IsDeleted { get; set; }
}
