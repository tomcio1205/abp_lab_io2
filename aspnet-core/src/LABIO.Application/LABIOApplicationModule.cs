using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LABIO.Authorization;

namespace LABIO
{
    [DependsOn(
        typeof(LABIOCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LABIOApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LABIOAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LABIOApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
