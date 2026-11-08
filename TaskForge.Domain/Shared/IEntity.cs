namespace TaskForge.Domain.Shared;

public interface IEntity<TKey> where TKey: notnull
{
   public TKey Id { get; set; } 
}