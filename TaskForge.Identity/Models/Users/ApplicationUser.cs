using Microsoft.AspNetCore.Identity;

namespace TaskForge.Identity.Models.Users;

public class ApplicationUser:IdentityUser<Guid>
{
    public required string FirstName { get; set; }
    public required  string LastName { get; set; }
    
}