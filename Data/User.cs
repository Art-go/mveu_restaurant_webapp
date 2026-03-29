using Microsoft.AspNetCore.Identity;

namespace Data;

public class User : IdentityUser<Guid>
{
    public string Name { get; set; } = string.Empty;
}