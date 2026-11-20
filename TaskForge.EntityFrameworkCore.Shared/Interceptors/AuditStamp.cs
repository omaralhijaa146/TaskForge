namespace TaskForge.EntityFrameworkCore.Shared.Interceptors;

/// <summary>
/// The single instant and actor applied across one unit of work, so every row in a
/// batch carries an identical stamp.
/// </summary>
internal readonly record struct AuditStamp(DateTimeOffset Now, Guid? UserId);
