using TaskForge.Domain.Shared.Audits;
using TaskForge.Domain.Shared.Entities;

namespace TaskForge.Domain.Audits;

public abstract class AuditedEntity:IEntity,IAudited
{
    public Guid Id { get; set; }
    public DateTimeOffset CreationTime { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTimeOffset? ModificationTime { get; set; }
    public Guid? ModifiedBy { get; set; }
}