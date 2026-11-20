namespace TaskForge.Domain.Shared.Audits;

public interface IHasModifiedBy
{
    Guid? ModifiedBy { get; set; }
}
