using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyecCarritoCompra.Startup))]
namespace ProyecCarritoCompra
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
