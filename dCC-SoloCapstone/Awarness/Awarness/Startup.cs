using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Awarness.Startup))]
namespace Awarness
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
