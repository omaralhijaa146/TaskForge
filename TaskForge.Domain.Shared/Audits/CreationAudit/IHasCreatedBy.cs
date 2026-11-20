namespace TaskForge.Domain.Shared.Audits;

public interface IHasCreatedBy
{
    Guid? CreatedBy { get; set; }
}
