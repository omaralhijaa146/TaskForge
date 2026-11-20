using TaskForge.Domain.Shared.Audits;
using TaskForge.Domain.Shared.Entities;

namespace TaskForge.Domain.Audits;

public abstract class FullAuditedEntity:AuditedEntity,IFullAudited
{
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletionTime { get; set; }
    public Guid? DeletedBy { get; set; }
}