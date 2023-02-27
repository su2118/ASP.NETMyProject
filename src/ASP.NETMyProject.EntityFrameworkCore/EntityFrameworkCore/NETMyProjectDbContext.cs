using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ASP.NETMyProject.Authorization.Roles;
using ASP.NETMyProject.Authorization.Users;
using ASP.NETMyProject.MultiTenancy;

namespace ASP.NETMyProject.EntityFrameworkCore
{
    public class NETMyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, NETMyProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NETMyProjectDbContext(DbContextOptions<NETMyProjectDbContext> options)
            : base(options)
        {
        }
    }
}
