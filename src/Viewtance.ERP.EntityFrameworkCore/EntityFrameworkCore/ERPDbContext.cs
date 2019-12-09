using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Viewtance.ERP.Authorization.Roles;
using Viewtance.ERP.Authorization.Users;
using Viewtance.ERP.MultiTenancy;

namespace Viewtance.ERP.EntityFrameworkCore
{
    public class ERPDbContext : AbpZeroDbContext<Tenant, Role, User, ERPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ERPDbContext(DbContextOptions<ERPDbContext> options)
            : base(options)
        {
        }
    }
}
