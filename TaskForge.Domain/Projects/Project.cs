using TaskForge.Domain.Shared;

namespace TaskForge.Domain.Projects;

public class Project:IEntity<Guid>
{
    public Guid Id { get; set; }
}