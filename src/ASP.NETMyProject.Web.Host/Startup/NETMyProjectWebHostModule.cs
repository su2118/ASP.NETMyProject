using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ASP.NETMyProject.Configuration;

namespace ASP.NETMyProject.Web.Host.Startup
{
    [DependsOn(
       typeof(NETMyProjectWebCoreModule))]
    public class NETMyProjectWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NETMyProjectWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NETMyProjectWebHostModule).GetAssembly());
        }
    }
}
