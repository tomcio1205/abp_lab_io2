using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LABIO.Authorization.Roles;
using LABIO.Authorization.Users;
using LABIO.MultiTenancy;

namespace LABIO.EntityFrameworkCore
{
    public class LABIODbContext : AbpZeroDbContext<Tenant, Role, User, LABIODbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LABIODbContext(DbContextOptions<LABIODbContext> options)
            : base(options)
        {
        }
    }
}
