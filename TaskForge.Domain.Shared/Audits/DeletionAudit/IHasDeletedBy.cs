namespace TaskForge.Domain.Shared.Audits;

public interface IHasDeletedBy
{
    Guid? DeletedBy { get; set; }
}
