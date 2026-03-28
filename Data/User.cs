using Microsoft.AspNetCore.Identity;

namespace Data;

public class User : IdentityUser
{
    public string Name { get; set; }
}