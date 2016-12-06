using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webproject.Startup))]
namespace Webproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
