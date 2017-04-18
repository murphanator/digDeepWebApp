using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(digDeepWebApp.Startup))]
namespace digDeepWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
