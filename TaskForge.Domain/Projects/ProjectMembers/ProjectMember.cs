using TaskForge.Domain.Shared.Audits;

namespace TaskForge.Domain.Projects.ProjectMembers;

// Composite key (ProjectId, UserId) so this cannot derive from AuditedEntity, which
// carries an Id. Membership rows are never modified in place — only added or removed —
// so creation audit is the only meaningful part.
public class ProjectMember : ICreationAudited
{
    public Guid ProjectId { get; set; }
    public Guid UserId { get; set; }
    public DateTimeOffset CreationTime { get; set; }
    public Guid? CreatedBy { get; set; }
}
