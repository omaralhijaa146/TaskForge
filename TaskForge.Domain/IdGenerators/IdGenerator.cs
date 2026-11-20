using TaskForge.Domain.Shared.IdGenerator;

namespace TaskForge.Domain.IdGenerators;

/// <summary>
/// Version 7 GUIDs are time-ordered, so they append to a clustered index instead of
/// fragmenting it the way random version 4 GUIDs do.
/// </summary>
public class IdGenerator : IIdGenerator
{
    public Guid Create()
    {
        return Guid.CreateVersion7();
    }
}
