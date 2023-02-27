using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASP.NETMyProject.Authorization;

namespace ASP.NETMyProject
{
    [DependsOn(
        typeof(NETMyProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NETMyProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NETMyProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NETMyProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
