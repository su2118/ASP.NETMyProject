using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASP.NETMyProject.EntityFrameworkCore;
using ASP.NETMyProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ASP.NETMyProject.Web.Tests
{
    [DependsOn(
        typeof(NETMyProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class NETMyProjectWebTestModule : AbpModule
    {
        public NETMyProjectWebTestModule(NETMyProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NETMyProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(NETMyProjectWebMvcModule).Assembly);
        }
    }
}