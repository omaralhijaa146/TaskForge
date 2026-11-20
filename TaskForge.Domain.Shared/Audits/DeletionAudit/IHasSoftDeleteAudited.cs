namespace TaskForge.Domain.Shared.Audits;

public interface IHasSoftDeleteAudited : IHasSoftDelete, IHasDeletionTime, IHasDeletedBy;
