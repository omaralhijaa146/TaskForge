using TaskForge.Domain.Shared;

namespace TaskForge.Domain.Projects.ProjectMembers;

public class ProjectMember
{
    public Guid ProjectId { get; set; }
    public Guid UserId { get; set; }
}