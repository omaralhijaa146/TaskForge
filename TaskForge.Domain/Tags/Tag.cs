using TaskForge.Domain.Shared;

namespace TaskForge.Domain.Tags;

public class Tag:IEntity<Guid>
{
    public Guid Id { get; set; }
}