using TaskForge.Domain.Shared;

namespace TaskForge.Domain.Tasks.TaskItems;

public class TaskItem:IEntity<Guid>
{
    public Guid Id { get; set; }
}