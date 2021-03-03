using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HuyWebStore.Configuration;

namespace HuyWebStore.Web.Host.Startup
{
    [DependsOn(
       typeof(HuyWebStoreWebCoreModule))]
    public class HuyWebStoreWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HuyWebStoreWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HuyWebStoreWebHostModule).GetAssembly());
        }
    }
}
