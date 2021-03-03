using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HuyWebStore.Authorization;

namespace HuyWebStore
{
    [DependsOn(
        typeof(HuyWebStoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HuyWebStoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HuyWebStoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HuyWebStoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
