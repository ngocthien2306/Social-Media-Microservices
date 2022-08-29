using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASP.NET.Authorization;

namespace ASP.NET
{
    [DependsOn(
        typeof(NETCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NETApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NETAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NETApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
