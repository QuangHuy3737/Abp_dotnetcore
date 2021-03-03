using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HuyWebStore.EntityFrameworkCore
{
    public static class HuyWebStoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HuyWebStoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HuyWebStoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
