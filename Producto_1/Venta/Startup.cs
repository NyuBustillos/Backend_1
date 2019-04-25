using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Venta.Startup))]
namespace Venta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
