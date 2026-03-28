using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data.EF;

public class AppDbContext: IdentityDbContext<User>
{
    
}