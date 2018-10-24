using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(biz.dfch.CS.Examples.SampleAspNetWebApp.Startup))]
namespace biz.dfch.CS.Examples.SampleAspNetWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
