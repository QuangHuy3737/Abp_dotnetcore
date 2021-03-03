using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HuyWebStore.Authorization.Roles;
using HuyWebStore.Authorization.Users;
using HuyWebStore.MultiTenancy;
using HuyWebStore.Products;

namespace HuyWebStore.EntityFrameworkCore
{
    public class HuyWebStoreDbContext : AbpZeroDbContext<Tenant, Role, User, HuyWebStoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Product> Products { get; set; }


        public HuyWebStoreDbContext(DbContextOptions<HuyWebStoreDbContext> options)
            : base(options)
        {
        }
    }
}
