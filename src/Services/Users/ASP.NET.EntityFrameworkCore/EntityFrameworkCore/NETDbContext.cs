using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ASP.NET.Authorization.Roles;
using ASP.NET.Authorization.Users;
using ASP.NET.MultiTenancy;

namespace ASP.NET.EntityFrameworkCore
{
    public class NETDbContext : AbpZeroDbContext<Tenant, Role, User, NETDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NETDbContext(DbContextOptions<NETDbContext> options)
            : base(options)
        {
        }
    }
}
