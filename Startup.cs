using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogOfLegends.Startup))]
namespace LogOfLegends
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
