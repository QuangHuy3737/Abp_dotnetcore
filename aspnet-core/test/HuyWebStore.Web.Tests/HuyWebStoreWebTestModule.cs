using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HuyWebStore.EntityFrameworkCore;
using HuyWebStore.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HuyWebStore.Web.Tests
{
    [DependsOn(
        typeof(HuyWebStoreWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HuyWebStoreWebTestModule : AbpModule
    {
        public HuyWebStoreWebTestModule(HuyWebStoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HuyWebStoreWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HuyWebStoreWebMvcModule).Assembly);
        }
    }
}