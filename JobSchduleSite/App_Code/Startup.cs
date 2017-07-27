using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JobSchduleSite.Startup))]
namespace JobSchduleSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
