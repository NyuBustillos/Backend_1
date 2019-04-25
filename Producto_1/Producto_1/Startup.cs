using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Producto_1.Startup))]
namespace Producto_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
