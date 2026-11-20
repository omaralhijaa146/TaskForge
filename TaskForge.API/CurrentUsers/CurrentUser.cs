using System.Security.Claims;
using TaskForge.Domain.Shared;

namespace TaskForge.API.CurrentUsers;

internal sealed class CurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _contextAccessor;

    private ClaimsPrincipal? User => _contextAccessor.HttpContext?.User;

    public CurrentUser(IHttpContextAccessor contextAccessor)
    {
        ArgumentNullException.ThrowIfNull(contextAccessor);
        _contextAccessor = contextAccessor;
    }

    public Guid? Id => GetUserId();
    public IEnumerable<string> Roles => GetUserRoles();
    public bool IsAuthenticated => User?.Identity?.IsAuthenticated ?? false;
    public string? UserName => GetClaimValue(ClaimTypes.Name);
    public string? Email => GetClaimValue(ClaimTypes.Email);
    public string? FirstName => GetClaimValue(ClaimTypes.Name);
    public string? LastName => GetClaimValue(ClaimTypes.Surname);

    public Claim? FindClaim(string claimType)
    {
        return User?.FindFirst(claimType);
    }

    public bool IsInRole(string role)
    {
        return User?.IsInRole(role) ?? false;
    }

    private string? GetClaimValue(string claimType)
    {
        return User?.FindFirst(claimType)?.Value;
    }

    private Guid? GetUserId()
    {
        return Guid.TryParse(GetClaimValue(ClaimTypes.NameIdentifier), out var id) ? id : null;
    }

    private IEnumerable<string> GetUserRoles()
    {
        return User?.FindAll(ClaimTypes.Role).Select(roleClaim => roleClaim.Value) ?? [];
    }
}
