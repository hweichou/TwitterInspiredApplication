using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwitterInspiredApplication.Startup))]
namespace TwitterInspiredApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
