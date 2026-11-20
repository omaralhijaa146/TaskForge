using System.Security.Claims;

namespace TaskForge.Domain.Shared;

public interface ICurrentUser
{
    public Guid? Id { get; }

    public IEnumerable<string> Roles { get; }

    public bool IsAuthenticated { get; }

    public string? UserName { get; }

    public string? Email { get; }

    public string? FirstName { get; }

    public string? LastName { get; }

    public Claim? FindClaim(string claimType);

    public bool IsInRole(string role);
}
