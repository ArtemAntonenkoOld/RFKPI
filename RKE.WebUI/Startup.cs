using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RKE.WebUI.Startup))]
namespace RKE.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
