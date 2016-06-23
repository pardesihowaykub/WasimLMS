using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WasimLMS.Startup))]
namespace WasimLMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
