using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiAplicacionWeb.Startup))]
namespace MiAplicacionWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
