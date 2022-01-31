using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeAssets.Startup))]
namespace HomeAssets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
