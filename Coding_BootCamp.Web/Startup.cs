using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coding_BootCamp.Web.Startup))]
namespace Coding_BootCamp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
