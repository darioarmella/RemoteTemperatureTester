using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ADSPortal.Startup))]
namespace ADSPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
