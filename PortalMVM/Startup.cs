using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortalMVM.Startup))]
namespace PortalMVM
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
