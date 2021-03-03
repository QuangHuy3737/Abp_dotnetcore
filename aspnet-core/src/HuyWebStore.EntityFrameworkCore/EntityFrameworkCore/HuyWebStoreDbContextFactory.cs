using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HuyWebStore.Configuration;
using HuyWebStore.Web;

namespace HuyWebStore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HuyWebStoreDbContextFactory : IDesignTimeDbContextFactory<HuyWebStoreDbContext>
    {
        public HuyWebStoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HuyWebStoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HuyWebStoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HuyWebStoreConsts.ConnectionStringName));

            return new HuyWebStoreDbContext(builder.Options);
        }
    }
}
