using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bilgi_Olcer.Identity
{
    public class UserIdentityDbContext:IdentityDbContext<User>
    {
        public UserIdentityDbContext(DbContextOptions<UserIdentityDbContext>options):base(options)
        {
                
        }
    }
}
