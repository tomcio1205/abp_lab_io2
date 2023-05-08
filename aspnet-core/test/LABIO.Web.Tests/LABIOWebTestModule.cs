using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LABIO.EntityFrameworkCore;
using LABIO.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LABIO.Web.Tests
{
    [DependsOn(
        typeof(LABIOWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LABIOWebTestModule : AbpModule
    {
        public LABIOWebTestModule(LABIOEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LABIOWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LABIOWebMvcModule).Assembly);
        }
    }
}