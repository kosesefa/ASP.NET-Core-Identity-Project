using AspNetCoreIdentity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Context
{
    public class xContext : IdentityDbContext<AppUser,AppRole,int>
    {
        public xContext(DbContextOptions<xContext> options) : base(options)
        {

        }
    }
    
}
