using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gettingStartedWithASP.Startup))]
namespace gettingStartedWithASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
